using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    class HeartDisappearState : Iitemstate
    {
        private Heart heart;
        public HeartDisappearState(Heart heart)
        {
            this.heart = heart;
            heart.HeartSprite = new ItemHeartSprite();
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
