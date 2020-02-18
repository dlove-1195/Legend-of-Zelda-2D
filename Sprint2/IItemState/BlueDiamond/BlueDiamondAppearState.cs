using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class BlueDiamondAppearState : IitemState
    {
        private BlueDiamond blueDiamond;
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();

        public BlueDiamondAppearState(BlueDiamond blueDiamond)
        {
            this.blueDiamond = blueDiamond;
            blueDiamond.blueDiamondSprite = new ItemBlueDiamondSprite(texture);
        }
        public void ChangeToAppear()
        {
           //already appear, do nothing
        }

        public void ChangeToDisappear()
        {
            blueDiamond.state = new BlueDiamondDisappearState(blueDiamond);
        }
    }
}
