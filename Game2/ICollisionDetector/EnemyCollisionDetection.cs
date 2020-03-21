using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
 
namespace Sprint2
{

    public class EnemyCollisionDetection : ICollisionDetection
    {
        //string to determine collision type : up,down,left, right 
        private EnemyCollisionHandler enemyHandler;
        private List<IEnemy> enemy;
        private List<KeyValuePair<int, int>> blockLocation;
        private int roomLeftCornerPosX;
        private int roomLeftCornerPosY;
        private int roomRightCornerPosX;
        private int roomRightCornerPosY;


        public EnemyCollisionDetection(ILevel level)
        {
            IRoom room = level.room;
            int roomWidth = (int)(Game1.WindowWidth * 0.68);
            int roomHeight = (int)(Game1.WindowHeight * 0.55);
            roomLeftCornerPosX = (int)(room.roomPos.X);
            roomLeftCornerPosY = (int)(room.roomPos.Y);
            roomRightCornerPosX = roomWidth + (int)(room.roomPos.X);
            roomRightCornerPosY = roomHeight + (int)(room.roomPos.Y);
            enemy = room.enemies;
            blockLocation = room.blockLocation;
            //no collision between enemy and pickupItem/npc 
            //no collision between item and item/block 

        }

        public void Update()
        {
            int totalEnemy = enemy.Count;
            for (int i = 0; i < totalEnemy; i++)
            {
                 
                IEnemy testEnemy = enemy[i];
                if (testEnemy != null)
                {
                    enemyHandler = new EnemyCollisionHandler(testEnemy);

                    Rectangle testEnemyRectangle = testEnemy.boundingBox;

                    Rectangle overlapRec;
                    string direction = "";

                    //detect enemy collision with block
                    int listLength = blockLocation.Count();
                    for (int j = 0; j < listLength; j++)
                    {
                        KeyValuePair<int, int> singleBlockLocation = blockLocation[j];
                        
                        Rectangle singleBlockRec = new Rectangle(singleBlockLocation.Key, singleBlockLocation.Value,
                            48, 54);

                        overlapRec = Rectangle.Intersect(testEnemyRectangle, singleBlockRec);
                        if (!overlapRec.IsEmpty)
                        {
                            direction = detectCollisionDirection(overlapRec, testEnemyRectangle, singleBlockRec);
                            enemyHandler.HandleEnemyBlockCollsion(direction);
                        }
                    }



                    //detect testEnemy collision with all other enemy 
                     listLength = enemy.Count();

                    for (int j = 0; j < listLength; j++)
                    {
                        if (i != j)
                        {
                            if (enemy[j] != null)
                            {
                                Rectangle singleEnemyRec = enemy[j].boundingBox;
                                overlapRec = Rectangle.Intersect(testEnemyRectangle, singleEnemyRec);
                                if (!overlapRec.IsEmpty)
                                {
                                    direction = detectCollisionDirection(overlapRec, testEnemyRectangle, singleEnemyRec);
                                    enemyHandler.HandleEnemyCollsion(direction, enemy[j]);
                                }
                            }
                        }

                    }

                    //enemy edge detection
                    direction = "";
                    if (testEnemyRectangle.X > roomRightCornerPosX)
                    {
                        direction = "right";
                    }
                    else if (testEnemyRectangle.X < roomLeftCornerPosX)
                    {
                        direction = "left";
                    }
                    else if (testEnemyRectangle.Y > roomRightCornerPosY)
                    {
                        direction = "down";
                    }
                    else if (testEnemyRectangle.Y < roomLeftCornerPosY)
                    {
                        direction = "up";
                    }
                    if (!direction.Equals(""))
                    {
                        enemyHandler.HandleEnemyWallCollsion(direction);
                    }



                }
            }
        }

 
        public string detectCollisionDirection(Rectangle overlapRec, Rectangle testEnemyRec, Rectangle objectRec)
        {

            string direction;
            if (overlapRec.Width >= overlapRec.Height) //top/buttom collison
            {
                if (testEnemyRec.Y >= objectRec.Y)
                {
                    direction = "down";
                }
                else
                {
                    direction = "up";
                }
            }
            else //left/right collison
            {
                if (testEnemyRec.X >= objectRec.X)
                {
                    direction = "right";
                }
                else
                {
                    direction = "left";
                }

            }

            return direction;
        }
    }

 

}


