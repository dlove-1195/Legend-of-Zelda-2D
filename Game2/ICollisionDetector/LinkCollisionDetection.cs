using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sprint2 {

    public class LinkCollisionDetection : ICollisionDetection
    {
        //string to determine collision type : up,down,left, right 
        private LinkCollisionHandler linkHandler;
        private List<IEnemy> enemy;
        private List<Iitem> item;
        private List<Inpc> npc;
        private List<KeyValuePair<int, int>> blockLocation;
        private List<KeyValuePair<int, int>> stairLocation;
        public List<string> doorDirection;

        private List<Rectangle> boundingBox; //for room15
        private int roomLeftCornerPosX;
        private int roomLeftCornerPosY;
        private int roomRightCornerPosX;
        private int roomRightCornerPosY;

        private Iplayer player ;
        

        public  LinkCollisionDetection (ILevel level, Iplayer link)
        {
            
            IRoom room = level.room;
            int roomWidth = (int)(Game1.WindowWidth * 0.68);
            int roomHeight = (int)(Game1.WindowHeight * 0.55);
            roomLeftCornerPosX = (int) (room.roomPos.X);
            roomLeftCornerPosY = (int)(room.roomPos.Y);
            roomRightCornerPosX = roomWidth+ (int)(room.roomPos.X);
            roomRightCornerPosY = roomHeight+(int)(room.roomPos.Y);
            enemy = room.enemies;
            item =  room.pickUpItems;
            npc =  room.npcs;
            blockLocation =  room.blockLocation;
            doorDirection = room.doorDirection;
            stairLocation = room.stairLocation;

            boundingBox = room.boundingBox;
            player = link;
            linkHandler =new LinkCollisionHandler(player, level) ;
    }

        public void Update()
        {


            Rectangle overlapRec;
       
            Rectangle linkRectangle = player.boundingBox;
            
            //loop for link/enemy collision 
            int listLength = enemy.Count();
            for(int i = 0;i< listLength; i++)
            {
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
                    for (int j = 0; j < EnemyProjectileRec.Count(); j++)
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
                    overlapRec = Rectangle.Intersect( swordRec, singleEnemyRec);
                    if (!overlapRec.IsEmpty)
                    {
                        //enemy damage 
                        linkHandler.HandleLinkWeaponEnemyCollsion(i);
                    }


                    // detect link weapon collison with enemy 
                    List<Rectangle> linkWeaponRec = player.getUsingItemRec();
                    for (int j = 0; j < linkWeaponRec.Count(); j++)
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

            listLength = item.Count();
            for (int i = 0; i < listLength; i++)
            {
                if (item[i] != null)
                {
                    Rectangle singleItemRec = item[i].boundingBox;


                    overlapRec = Rectangle.Intersect(linkRectangle, singleItemRec);
                    if (!overlapRec.IsEmpty)
                    {

                        linkHandler.HandleLinkItemCollsion(i);
                    }
                }
 
            }


            //loop for link/NPC collsion 

            listLength = npc.Count();
            
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
                listLength = blockLocation.Count();
                for (int i = 0; i < listLength; i++)
                {
                    KeyValuePair<int, int> singleBlockLocation = blockLocation[i];
                    //for now, assume block width and height are 100, will change later based on the doungeon spritesheet we found 
                    Rectangle singleBlockRec = new Rectangle(singleBlockLocation.Key, singleBlockLocation.Value,
                        48, 54);

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
                listLength = boundingBox.Count();
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


            //loop for door collision (for each door in each room)
            
            listLength = doorDirection.Count();
            for (int i = 0; i < listLength; i++)
            {
                string singleDoorDirection = doorDirection[i];

 
                if (doorDirection.Equals("Up") )
                {
                    if (  Link.posY <= roomLeftCornerPosY&&! Camera.switchRoom)//(int)singleDoorLocation.Value.Y)
                    {
                        linkHandler.HandleLinkDoorCollsion(singleDoorDirection);
                    }
                }
                else if (doorDirection.Equals("Down"))
                {
                    if (Link.posY >= roomRightCornerPosY&& !Camera.switchRoom)
                    {
                        linkHandler.HandleLinkDoorCollsion(singleDoorDirection);
                    }
                }
                else if (doorDirection.Equals("Left"))
                {
                    if (Link.posX <= roomLeftCornerPosX && !Camera.switchRoom)
                    {
                        linkHandler.HandleLinkDoorCollsion(singleDoorDirection);
                    }
                }
                else if (doorDirection.Equals("Down"))
                {
                    if (Link.posX >= roomRightCornerPosX && !Camera.switchRoom)
                    {
                        linkHandler.HandleLinkDoorCollsion(singleDoorDirection);
                    }
                }



            } 

            //loop for stair collision
            listLength = stairLocation.Count();
            for (int i = 0; i < listLength; i++)
            {
                KeyValuePair<int, int> singleStairLocation = stairLocation[i];
                Rectangle singleStairRec = new Rectangle(singleStairLocation.Key, singleStairLocation.Value, 48, 54);

                overlapRec = Rectangle.Intersect(linkRectangle, singleStairRec);
                if (!overlapRec.IsEmpty)
                {
                    String direction = detectCollisionDirection(overlapRec, linkRectangle, singleStairRec);
                    if (direction.Equals("left"))
                    {
                        string downstair = "down";
                        linkHandler.HandleLinkStairCollsion(downstair);
                    }
                }
            }



            //link edge collision if no boundingBox in room
            //room15 no Link edge collision
            if (boundingBox.Count == 0)
            {
                if (doorDirection.Contains("Right"))
                {
                    if (Link.posX > roomRightCornerPosX && (Link.posY < Game1.WindowHeight * 0.45 || Link.posY > Game1.WindowHeight * (0.45 + 0.1)))
                    {
                        linkHandler.remainPosition("Right");
                    }
                }
                else
                {
                    if (Link.posX > roomRightCornerPosX)
                    {
                        linkHandler.remainPosition("Right");
                    }
                }
                if (doorDirection.Contains("Left"))
                {
                    if (Link.posX < roomLeftCornerPosX && (Link.posY < Game1.WindowHeight * 0.45 || Link.posY > Game1.WindowHeight * (0.45 + 0.1)))
                    {
                        linkHandler.remainPosition("Left");
                    }
                }
                else
                {
                    if (Link.posX < roomLeftCornerPosX)
                    {

                        linkHandler.remainPosition("Left");
                    }
                }
                if (doorDirection.Contains("Down"))
                {
                    if (Link.posY > roomRightCornerPosY && (Link.posX < Game1.WindowWidth * 0.465 || Link.posX > Game1.WindowWidth * (0.465 + 0.07)))
                    {
                        linkHandler.remainPosition("Down");
                    }
                }
                else
                {
                    if (Link.posY > roomRightCornerPosY)
                    {
                        linkHandler.remainPosition("Down");
                    }
                }
                if (doorDirection.Contains("Up"))
                {
                    if (Link.posY < roomLeftCornerPosY && (Link.posX < Game1.WindowWidth * 0.465 || Link.posX > Game1.WindowWidth * (0.465 + 0.07)))
                    {
                        linkHandler.remainPosition("Up");
                    }
                }
                else
                {
                    if (Link.posY < roomLeftCornerPosY)
                    {
                        linkHandler.remainPosition("Up");
                    }
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

    
 
    
 
