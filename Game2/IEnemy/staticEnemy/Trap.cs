using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class Trap : IEnemy
    {

        public ISprite trapSprite;


        //the current position of the trap
        public static int posX = 400;
        public static int posY = 200;




        public Trap()
        {
            trapSprite = new TrapSprite(Texture2DStorage.GetEnemySpriteSheet2());
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
            trapSprite.Update();

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            trapSprite.Draw(spriteBatch,new Vector2(posX,posY));
        }




    }
}
