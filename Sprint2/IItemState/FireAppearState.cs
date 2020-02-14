using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class FireAppearState: IItemState
    {
        private Fire fire;
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        public FireAppearState(Fire fire)
        {

            this.fire = fire;
            fire.fireSprite = new FireSprite(texture);
        }
        public void ChangeToDisappear()
        {
            fire.state = new FireDisappearState(fire);
        }

        public void ChangeToAppear()
        {
            //ALREADY APPEAR
        }

    }
}
