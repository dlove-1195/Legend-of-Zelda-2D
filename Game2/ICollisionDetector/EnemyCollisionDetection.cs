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
            roomWidth=room.vector.x;
            roomHeight=room.vector.y;
            enemy = room.enemy;
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
                        string direction = detectCollisionDirection(overlapRec, singleBlockRec);
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
                            string direction = detectCollisionDirection(overlapRec, singleEnemyRec);
                            enemyHandler.HandleEnemyCollsion(direction);
                        }
                    }

                }

                //enemy edge detection
                if (testEnemyRectangle.X > roomWidth)
                {
                     enemyHandler.changeDirection("right");
                }
                else if (testEnemyRectangle.X < 0)
                {
                    enemyHandler.changeDirection("left");
                }
                else if (testEnemyRectangle.Y > roomHeight)
                {
                    enemyHandler.changeDirection("down");
                }
                else if (testEnemyRectangle.Y < 0)
                {
                    enemyHandler.changeDirection("up");
                }
              
                     



            }
        }


        //maybe need to add a another helping method to detect direction, return a string
        //call this method inside the update before handleCollison method
        //use Rectangle.Intersect(recA, recB) 
        //return a new rec that is the overlap area, otherwise an empty rec
        public string detectCollisionDirection(Rectangle overlapRec, Rectangle objectRec)
        {
             
            return "";
        }
    }

 

}


