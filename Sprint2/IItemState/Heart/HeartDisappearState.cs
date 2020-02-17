using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class HeartDisappearState : IitemState
    {
        private Heart heart;
        public HeartDisappearState(Heart heart)
        {
            this.heart = heart;
            heart.heartSprite = new ItemHeartSprite();
        }
        public void ChangeToAppear()
        {
            heart.state = new HeartAppearState(heart);
        }

        public void ChangeToDisappear()
        {
            //already disappear, do nothing
        }
    }
}
