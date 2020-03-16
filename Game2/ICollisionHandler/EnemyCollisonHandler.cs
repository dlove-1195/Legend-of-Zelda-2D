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
                case "top":
                    enemy.ChangeToDown();
                    break;
                case "buttom":
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
                    enemy.ChangeToLeft();
                    otherEnemy.ChangeToRight();
                    break;
                case "right":
                    enemy.ChangeToRight();
                    otherEnemy.ChangeToLeft();
                     
                    break;
                case "top":
                    enemy.ChangeToUp();
                    otherEnemy.ChangeToDown();
                    break;
                case "bottom":
                    enemy.ChangeToDown();
                    otherEnemy.ChangeToUp();
                    break;
                default:
                    Console.WriteLine("error: no such situation");
                    break;
            }

        }
    }
}
