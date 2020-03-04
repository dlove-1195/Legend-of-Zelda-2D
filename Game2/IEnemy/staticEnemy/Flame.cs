using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
 

namespace Sprint2
{
    public class Flame : IEnemy
    {

        public ISprite flameSprite;


        //the current position of the trap
        public static int posX = 400;
        public static int posY = 200;




        public Flame()
        {
            flameSprite = new FlameSilentBurningSprite(Texture2DStorage.GetEnemySpriteSheet2());
        }



        public void ChangeToRight()
        {
            //have no state
        }
        public void ChangeToLeft()
        {
            //have no state
        }
        public void ChangeToUp()
        {
            //have no state
        }
        public void ChangeToDown()
        {
            //have no state
        }
        public void ChangeState(IEnemyState state)
        {
            //have no state

        }

        public void ChangeSprite(ISprite sprite)
        {
            //only one sprite
            
        }



        public void Update()
        {
            flameSprite.Update();

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            flameSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }




    }
}
