using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{

    public class EnemyCollisionDetection : ICollisionDetection
    {
        //string to determine collision type : up,down,left, right 
        private EnemyCollisionHandler enemyHandler;
        private List<IEnemy> enemy;
        private List<KeyValuePair<int, int>> blockLocation;
        private int roomWidth;
        private int roomHeight;


        public EnemyCollisionDetection(IRoom room)
        {
            roomWidth=(int) room.roomSize.X;
            roomHeight=(int) room.roomSize.Y;
            enemy = room.enemies;
            blockLocation = room.blockLocation;
            //no collision between enemy and pickupItem/npc 

        }

        public void Update()
        {
            int totalEnemy = enemy.Count;
            for (int i = 0; i < totalEnemy; i++)
            {

                IEnemy testEnemy = enemy[i];
                enemyHandler = new EnemyCollisionHandler(testEnemy);
                Rectangle testEnemyRectangle = testEnemy.boundingBox;
                Rectangle overlapRec;
                string direction="";

                //detect enemy collision with block
                int listLength = blockLocation.Count();
                for (int j = 0; j < listLength; j++)
                {
                    KeyValuePair<int, int> singleBlockLocation = blockLocation[i];
                    //for now, assume block width and height are 100, will change later based on the doungeon spritesheet we found 
                    Rectangle singleBlockRec = new Rectangle(singleBlockLocation.Key, singleBlockLocation.Value,
                        100, 100);

                    overlapRec = Rectangle.Intersect(testEnemyRectangle, singleBlockRec);
                    if (!overlapRec.IsEmpty)
                    {
                        direction = detectCollisionDirection(overlapRec, testEnemyRectangle, singleBlockRec);
                        enemyHandler.HandleEnemyBlockCollsion(direction);
                    }
                }



                //detect testEnemy collision with all other enemy 
                 listLength =  enemy.Count();
                 
                for (int j = 0; j < listLength; j++)
                {
                    if (i != j)
                    {
                        Rectangle singleEnemyRec = enemy[j].boundingBox;
                        overlapRec = Rectangle.Intersect(testEnemyRectangle, singleEnemyRec);
                        if (!overlapRec.IsEmpty)
                        {
                              direction = detectCollisionDirection(overlapRec, testEnemyRectangle, singleEnemyRec);
                            enemyHandler.HandleEnemyCollsion(direction,  enemy[j]);
                        }
                    }

                }

                //enemy edge detection
               
                if (testEnemyRectangle.X > roomWidth)
                {
                    direction = "right";
                }
                else if (testEnemyRectangle.X < 0)
                {
                    direction = "left";
                }
                else if (testEnemyRectangle.Y > roomHeight)
                {
                    direction = "buttom";
                }
                else if (testEnemyRectangle.Y < 0)
                {
                    direction = "top";
                }
                if (!direction.Equals(""))
                {
                    enemyHandler.HandleEnemyBlockCollsion(direction);
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
                    direction = "top";
                }
                else
                {
                    direction = "bottom";
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


