using System;


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
                    enemy.posY += 2;
                    enemy.ChangeToDown();
                    break;
                case "down":
                    enemy.posY -= 2;
                    enemy.ChangeToUp();
                    break;
                case "left":
                    enemy.posX += 2;
                    enemy.ChangeToRight();
                    break;
                case "right":
                    enemy.posX -= 2;
                    enemy.ChangeToLeft();
                    break;

            }
           
        }


        public void HandleEnemyWallCollsion(String direction)
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
        public void HandleEnemyCollsion(string direction, IEnemy otherEnemy)
        {
            switch (direction)

            {
                case "left":
                    enemy.posY-=5;
                    otherEnemy.posY+=5;
                    break;
                case "right":
                    enemy.posY += 5;
                    otherEnemy.posY -= 5;

                    break;
                case "top":
                    enemy.posX += 5;
                    otherEnemy.posX -= 5;
                    break;
                case "bottom":
                    enemy.posX -= 5;
                    otherEnemy.posX += 5;
                    break;
                default:
                    Console.WriteLine("error: no such situation");
                    break;
            }

        }
    }
}
