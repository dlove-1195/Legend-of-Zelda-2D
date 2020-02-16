using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class BlueDiamondDisappearState : IStaticitemstate
    {
        private BlueDiamond blueDiamond;
        public BlueDiamondDisappearState(BlueDiamond blueDiamond)
        {
            this.blueDiamond = blueDiamond;
            blueDiamond.blueDiamondSprite = new ItemBlueDiamondSprite();
        }
        public void ChangeToAppear()
        {
            blueDiamond.state = new BlueDiamondDisappearState(blueDiamond);
        }

        public void ChangeToDisappear()
        {
            //already disappear, do nothing
        }
    }
}
