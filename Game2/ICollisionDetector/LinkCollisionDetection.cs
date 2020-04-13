using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sprint2
{

    public class LinkCollisionDetection : ICollisionDetection
    {
        //string to determine collision type : up,down,left, right 
        private LinkCollisionHandler linkHandler;
        private List<IEnemy> enemy;
        private List<IItem> item;
        private List<INpc> npc;
        private List<KeyValuePair<int, int>> blockLocation;
        private List<KeyValuePair<Vector2, Vector2>> stair;
        private List<Rectangle> boundingBox; //for room15
        private int roomLeftCornerPosX;
        private int roomLeftCornerPosY;
        private int roomRightCornerPosX;
        private int roomRightCornerPosY;

        private IPlayer player;

        private List<string> DoorDirection { get; set; } 
        private IRoom room;

        public LinkCollisionDetection(ILevel level, IPlayer link, IInventory inventory)
        {
            if (level == null)
            {
                throw new ArgumentNullException(nameof(level));
            }
            this.room = level.room;
            int roomWidth = (int)(800 * 0.68);
            int roomHeight = (int)(600 * 0.55);
            roomLeftCornerPosX = (int)(room.roomPos.X);
            roomLeftCornerPosY = (int)(room.roomPos.Y);
            roomRightCornerPosX = roomWidth + (int)(room.roomPos.X);
            roomRightCornerPosY = roomHeight + (int)(room.roomPos.Y);
            enemy = room.enemies;
            item = room.pickUpItems;
            npc = room.npcs;
            blockLocation = room.blockLocation;
            DoorDirection = room.doorDirection;
            stair = room.stair;

            boundingBox = room.boundingBox;
            player = link;
            linkHandler = new LinkCollisionHandler(player, level, inventory);
        }

        public void Update()
        {


            Rectangle overlapRec;

            Rectangle linkRectangle = player.boundingBox;

            //loop for link/enemy collision 
            int listLength = enemy.Count;
            for (int i = 0; i < listLength; i++)
            {
                if (enemy[i] != null && enemy[i].blood <= 0 && enemy[i].sparkTimer >= 10)
                {
                    //diamond need to be yellow
                    IItem diamond = new YellowDiamond(new Vector2(enemy[i].posX, enemy[i].posY));
                    room.pickUpItems.Add(diamond);
                    room.setEnemyToNull(i);
                }
                if (enemy[i] != null)
                {
                    Rectangle singleEnemyRec = enemy[i].boundingBox;
                    //detect link body collision with enemy body 
                    overlapRec = Rectangle.Intersect(linkRectangle, singleEnemyRec);
                    if (!overlapRec.IsEmpty)
                    {
                        //link damage and being pushed in opposite direction
                        String direction = detectCollisionDirection(overlapRec, linkRectangle, singleEnemyRec);
                        linkHandler.HandleLinkEnemyCollsion(direction);

                    }



                    //detect link collision with enemy projectile 
                    List<Rectangle> EnemyProjectileRec = enemy[i].getProjectileRec();
                    for (int j = 0; j < EnemyProjectileRec.Count; j++)
                    {
                        overlapRec = Rectangle.Intersect(linkRectangle, EnemyProjectileRec[j]);
                        if (!overlapRec.IsEmpty)
                        {
                            //link damage by projectile, will not be pushed

                            linkHandler.HandleLinkProjectileCollsion();

                        }

                    }

                    //detect link's simple attack collsion with enemy
                    Rectangle swordRec = player.simpleAttackBox;
                    overlapRec = Rectangle.Intersect(swordRec, singleEnemyRec);
                    if (!overlapRec.IsEmpty)
                    {
                        //enemy damage

                        linkHandler.HandleLinkWeaponEnemyCollsion(i);

                    }


                    // detect link weapon collison with enemy 
                    List<Rectangle> linkWeaponRec = player.getUsingItemRec();
                    for (int j = 0; j < linkWeaponRec.Count; j++)
                    {
                        overlapRec = Rectangle.Intersect(singleEnemyRec, linkWeaponRec[j]);
                        if (!overlapRec.IsEmpty)
                        {
                            //enemy damage 

                            linkHandler.HandleLinkWeaponEnemyCollsion(i);

                        }


                    }
                }

            }

            //loop for link/item collsion 

            listLength = item.Count;
            for (int i = 0; i < listLength; i++)
            {
                if (item[i] != null)
                {
                    Rectangle singleItemRec = item[i].BoundingBox; 

                    overlapRec = Rectangle.Intersect(linkRectangle, singleItemRec);
                    if (!overlapRec.IsEmpty)
                    {
                        if (item[i] is LockedDoor)
                        {
                            String direction = detectCollisionDirection(overlapRec, linkRectangle, singleItemRec);
                            linkHandler.HandleLinkLockedDoorCollision(i, direction);
                        }
                        else
                        {
                            linkHandler.HandleLinkItemCollsion(i);
                        }
                            
                    }
                }

            }


            //loop for link/NPC collsion 

            listLength = npc.Count;

            for (int i = 0; i < listLength; i++)
            {

                Rectangle singleNpcRec = npc[i].boundingBox;

                overlapRec = Rectangle.Intersect(linkRectangle, singleNpcRec);

                if (!overlapRec.IsEmpty)
                {
                    String direction = detectCollisionDirection(overlapRec, linkRectangle, singleNpcRec);
                    linkHandler.HandleLinkNpcCollsion(direction);
                }



            }


            //loop for link/Block collsion when no boundingBox
            if (boundingBox.Count == 0)
            {
                listLength = blockLocation.Count;
                for (int i = 0; i < listLength; i++)
                {
                    KeyValuePair<int, int> singleBlockLocation = blockLocation[i];

                    Rectangle singleBlockRec = new Rectangle(singleBlockLocation.Key, singleBlockLocation.Value,
                        30, 30);

                    overlapRec = Rectangle.Intersect(linkRectangle, singleBlockRec);

                    if (!overlapRec.IsEmpty)
                    {
                        String direction = detectCollisionDirection(overlapRec, linkRectangle, singleBlockRec);

                        linkHandler.HandleLinkBlockCollsion(direction);

                    }
                }
            }
            //loop for Link/boundingBox collsion for room15
            else
            {
                listLength = boundingBox.Count;
                for (int i = 0; i < listLength; i++)
                {
                    Rectangle singleBoxRec = boundingBox[i];
                    overlapRec = Rectangle.Intersect(linkRectangle, singleBoxRec);

                    if (!overlapRec.IsEmpty)
                    {
                        String direction = detectCollisionDirection(overlapRec, linkRectangle, singleBoxRec);

                        linkHandler.HandleLinkBlockCollsion(direction); //LinkBoxCollsion is same as LinkBlockCollsion

                    }
                }
            }
             

            //link edge collision if no boundingBox in room
            //room15 no Link edge collision
            if (boundingBox.Count == 0)
            {
                if (DoorDirection.Contains("Right"))
                {
                    if (Link.posX > roomRightCornerPosX && (Link.posY < 900 * 0.45 || Link.posY > 900 * (0.45 + 0.1)))
                    {
                        linkHandler.StayPosition("Right");
                    }
                }
                else
                {
                    if (Link.posX > roomRightCornerPosX)
                    {
                        linkHandler.StayPosition("Right");
                    }
                }
                if (DoorDirection.Contains("Left"))
                {
                    if (Link.posX < roomLeftCornerPosX && (Link.posY < 900 * 0.45 || Link.posY > 900 * (0.45 + 0.1)))
                    {
                        linkHandler.StayPosition("Left");
                    }
                }
                else
                {
                    if (Link.posX < roomLeftCornerPosX)
                    {

                        linkHandler.StayPosition("Left");
                    }
                }
                if (DoorDirection.Contains("Down"))
                {
                    if (Link.posY > roomRightCornerPosY && (Link.posX < Game1.WindowWidth * 0.465 || Link.posX > Game1.WindowWidth * (0.465 + 0.07)))
                    {
                        linkHandler.StayPosition("Down");
                    }
                }
                else
                {
                    if (Link.posY > roomRightCornerPosY)
                    {
                        linkHandler.StayPosition("Down");
                    }
                }
                if (DoorDirection.Contains("Up"))
                {
                    if (Link.posY < roomLeftCornerPosY && (Link.posX < Game1.WindowWidth * 0.465 || Link.posX > Game1.WindowWidth * (0.465 + 0.07)))
                    {
                        linkHandler.StayPosition("Up");
                    }
                }
                else
                {
                    if (Link.posY < roomLeftCornerPosY)
                    {
                        linkHandler.StayPosition("Up");
                    }
                }
            
        
        }


        //loop for door collision (for each door in each room) 
        listLength = DoorDirection.Count;
            for (int i = 0; i < listLength; i++)
            {
                String singleDoorDirection = DoorDirection[i];


                if (singleDoorDirection.Equals("Up", StringComparison.Ordinal))
                {
                    if (Link.posY <= roomLeftCornerPosY - 45 && !Camera.SwitchRoom)//(int)singleDoorLocation.Value.Y)
                    {
                        linkHandler.HandleLinkDoorCollsion(singleDoorDirection);
                    }
                }
                else if (singleDoorDirection.Equals("Down", StringComparison.Ordinal))
                {
                    if (Link.posY >= roomRightCornerPosY + 45 && !Camera.SwitchRoom)
                    {
                        linkHandler.HandleLinkDoorCollsion(singleDoorDirection);
                    }
                }
                else if (singleDoorDirection.Equals("Left", StringComparison.Ordinal))
                {
                    if (Link.posX <= roomLeftCornerPosX - 45 && !Camera.SwitchRoom)
                    {
                        linkHandler.HandleLinkDoorCollsion(singleDoorDirection);
                    }
                }
                else if (singleDoorDirection.Equals("Right", StringComparison.Ordinal))
                {
                    if (Link.posX >= roomRightCornerPosX + 45 && !Camera.SwitchRoom)
                    {
                        linkHandler.HandleLinkDoorCollsion(singleDoorDirection);
                    }
                }
            }

            //loop for stair collision
            listLength = stair.Count;
            for (int i = 0; i < listLength; i++)
            {
                KeyValuePair<Vector2, Vector2> singleStair = stair[i];
                Vector2 stairPos = singleStair.Key;
                Vector2 stairDest = singleStair.Value;

                Rectangle singleStairRec = new Rectangle((int)stairPos.X, (int)stairPos.Y, 48, 54);
                overlapRec = Rectangle.Intersect(linkRectangle, singleStairRec);

                if (!overlapRec.IsEmpty)

                {

                    String direction = detectCollisionDirection(overlapRec, linkRectangle, singleStairRec);
                    linkHandler.HandleLinkStairCollsion(stairDest, direction);

                }
            }
        }



        public string detectCollisionDirection(Rectangle overlapRec, Rectangle linkRec, Rectangle objectRec)
        {

            string direction;
            if (overlapRec.Width >= overlapRec.Height) //top/buttom collison
            {
                if (linkRec.Y >= objectRec.Y)
                {
                    direction = "Up";
                }
                else
                {
                    direction = "Down";
                }
            }
            else //left/right collison
            {
                if (linkRec.X >= objectRec.X)
                {
                    direction = "Right";
                }
                else
                {
                    direction = "Left";
                }

            }

            return direction;
        }

    }
}

