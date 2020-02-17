using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class ClockDisappearState : IStaticitemstate
    {
        private Clock clock;
       
        public ClockDisappearState(Clock clock)
        {
            this.clock = clock;
            clock.clockSprite = new ClockSprite();
        }
        public void ChangeToAppear()
        {
            clock.state = new ClockAppearState(clock);
        }

        public void ChangeToDisappear()
        {
            //already disappear, do nothing
        }
    }
}
