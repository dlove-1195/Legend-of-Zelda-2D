using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class EnemyCollisionHandler  
    {
        IEnemy enemy; 
        
        public EnemyCollisionHandler(IEnemy enemy)
        {
            this.enemy= enemy;
        }

        // public void HandleLinkNpcCollsion(String side);
        //may need add side in the future 
        public void HandleEnemyBlockCollsion(String direction )
        {
            //change to different direction depends on collision direction
            switch (direction)
            {
                case "up":
                    enemy.ChangeToDown();
                    break;
                case "down":
                    enemy.ChangeToUp();
                    break;
                case "left":
                    enemy.ChangeToRight();
                    break;
                case "right":
                    enemy.ChangeToLeft();
                    break;

            }
           
        }
        public void HandleEnemyCollsion(string direction)
        {
             
        }

        public void changeDirection(string direction)
        {
            switch (direction)

            {
                case "left":
                    enemy.ChangeToRight();
                    break;
                case "right":
                    enemy.ChangeToLeft();
                    break;
                case "up":
                    enemy.ChangeToUp();
                    break;
                case "down":
                    enemy.ChangeToDown();
                    break;
                default:
                    Console.WriteLine("error: no such situation");
                    break;
            }

        }

    }
}
