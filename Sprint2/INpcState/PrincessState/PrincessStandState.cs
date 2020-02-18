using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class PrincessStandState: INpcState
    {
        private Princess princess;
        private Texture2D texture = Texture2DStorage.GetNpcSpriteSheet();
        public PrincessStandState(Princess princess)
        {

            this.princess = princess;
            princess.PrincessSprite = new PrincessStandSprite(texture);
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
            //already up
        }

        public void ChangeToDown()
        {
            //none
        }
        
    }
}
