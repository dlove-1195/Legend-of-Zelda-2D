using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class FireDisappearState: IItemState
    {
        private Fire fire;
         
        public FireDisappearState(Fire fire)
        {

            this.fire = fire;
            fire.fireSprite = new FireSprite();

        }
        public void ChangeToDisappear()
        {
            //already disappear
        }

        public void ChangeToAppear()
        {
            fire.state = new FireAppearState(fire);
        }
    }
}
