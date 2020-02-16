using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class ClockAppearState : IStaticitemstate
    {
        private Clock clock;
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        public ClockAppearState(Clock clock)
        {
            this.clock = clock;
            clock.clockSprite = new ClockSprite(texture);
        }
        public void ChangeToAppear()
        {
            //already appear, do nothing
        }

        public void ChangeToDisappear()
        {
            clock.state = new ClockDisappearState(clock);
        }
    }
}
