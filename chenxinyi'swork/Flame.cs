using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
        public void ChangeToLeft()
        {
        }
        public void ChangeToUp()
        {
        }
        public void ChangeToDown()
        {
        }




        public void Update()
        {
            flameSprite.Update();

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            flameSprite.Draw(spriteBatch, new Vector2(posX, posY);
        }




    }
}
