using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class Princess: INpc
    {

        public INpcState state;
        public ISprite PrincessSprite;

        public Princess()
        {

            state = new PrincessStandState(this);
        }

        public void previousEnemy(Game1 myGame)
        {
            state = new PrincessDisappearState(this);
           
        }
       

        public void ChangeToRight()
        {
            //none
        }
        public void ChangeToLeft()
        {
            //none
        }
        public void ChangeToUp()
        {
            //none
        }
        public void ChangeToDown()
        {
            //none
        }
        public void Update()
        {

            //do nothing

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            PrincessSprite.Draw(spriteBatch, new Vector2(Dragon.posX, Dragon.posY));
        }

       


        

    }
}
