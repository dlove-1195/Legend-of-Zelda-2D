using Microsoft.Xna.Framework.Graphics;
using System;
 
namespace Sprint2 
{
    public class EnemyWalkLeftState: IEnemyState
    {
        private int number; 
        private IEnemy  enemy;
       //private Texture2D texture1 = Texture2DStorage.GetEnemySpriteSheet();
        private Texture2D texture2 = Texture2DStorage.GetEnemySpriteSheet2();
        private Texture2D texture3 = Texture2DStorage.GetEnemySpriteSheet3();
        public EnemyWalkLeftState(IEnemy enemy, int number)
        {
            if (enemy == null)
            {
                throw new ArgumentNullException(nameof(enemy));
            }
            this.number = number;
            this.enemy = enemy;
            switch (number)
            {
                case 0:

                    enemy.ChangeSprite(new BatSprite(texture3, "Left",enemy));
                    break;
                case 1:
                    enemy.ChangeSprite(new StalfoSprite(texture3, "Left",enemy));
                    break;
                case 2:

                    enemy.ChangeSprite(new RedGoriyaSprite(texture3, "Left",enemy));
                    break;
                case 3:
                    enemy.ChangeSprite(new ZolSprite(texture3, "Left",enemy));
                    break;
                case 4:
                    enemy.ChangeSprite(new RopeSprite(texture2, "Left",enemy));

                    break;
                default:
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                    Console.WriteLine("error: no such situation");
#pragma warning restore CA1303 // Do not pass literals as localized parameters
                    break;
            }
        }
        public void ChangeToRight()
        {
            enemy.ChangeState(new EnemyWalkRightState(enemy, number));
        }

        public void ChangeToLeft()
        {
           //nothing
        }

        public void ChangeToUp()
        {
            enemy.ChangeState(new EnemyWalkUpState(enemy, number));
        }

        public void ChangeToDown()
        {
            enemy.ChangeState(new EnemyWalkDownState(enemy, number));
        }
        public void GetDamaged()
        {
            //
        }
    }
}
