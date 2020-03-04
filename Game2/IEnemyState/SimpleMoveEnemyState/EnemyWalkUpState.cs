using Microsoft.Xna.Framework.Graphics;
using System;
 
namespace Sprint2 
{
    public class EnemyWalkUpState: IEnemyState
    {
        private int number; 
        private IEnemy  enemy;
        private Texture2D texture = Texture2DStorage.GetEnemySpriteSheet();
        public EnemyWalkUpState(IEnemy enemy, int number)
        {
            this.number = number;
            this.enemy = enemy;
            switch (number)
            {
                case 0:
                   enemy.ChangeSprite(new BatSprite(texture, "Up"));
                     break;
                case 1:
                    enemy.ChangeSprite(new StalfoSprite(texture, "Up"));
                    break;
                case 2:

                  enemy.ChangeSprite(new RedGoriyaSprite(texture, "Up"));
                  break;
                case 3:
                    enemy.ChangeSprite(new ZolSprite(texture, "Up"));
                    break;
                case 4:
                    enemy.ChangeSprite(new RopeSprite(texture, "Up"));

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
            
        }

        public void ChangeToDown()
        {
            enemy.ChangeState(new EnemyWalkDownState(enemy, number));
        }
     
    }
}
