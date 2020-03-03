using Microsoft.Xna.Framework.Graphics;
using System;
 
namespace Sprint2 
{
    public class EnemyWalkDownState: IEnemyState
    {
        private int number; 
        private IEnemy  enemy;
        private Texture2D texture = Texture2DStorage.GetEnemySpriteSheet();
        public EnemyWalkDownState(IEnemy enemy, int number)
        {
            this.number = number;
            this.enemy = enemy;
            switch (number)
            {
                case 0:
                    enemy.ChangeSprite(new BatSprite(texture, "Left"));
                    break;
                case 1:
                    enemy.ChangeSprite(new StalfoSprite(texture, "Left"));
                    break;
                case 2:

                    enemy.ChangeSprite(new RedGoriyaSprite(texture, "Left"));
                    break;
                case 3:
                    enemy.ChangeSprite(new ZolSprite(texture, "Left"));
                    break;
                case 4:
                    enemy.ChangeSprite(new RopeSprite(texture, "Left"));
                    
                    break;
                default:
                    Console.WriteLine("error: no such situation");
                    break;
            }
        }
        public void ChangeToRight()
        {
            enemy.ChangeState(new EnemyWalkRightState(enemy, number));
        }

        public void ChangeToLeft()
        {
            enemy.ChangeState(new EnemyWalkLeftState(enemy, number));
        }

        public void ChangeToUp()
        {
            enemy.ChangeState(new EnemyWalkUpState(enemy, number));
        }

        public void ChangeToDown()
        {
            // already down 
        }
     
    }
}
