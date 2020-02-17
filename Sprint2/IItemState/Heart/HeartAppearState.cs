using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class HeartAppearState : IStaticitemstate
    {
        private Heart heart;
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();

        public HeartAppearState(Heart heart)
        {
            this.heart = heart;
            heart.heartSprite = new ItemHeartSprite(texture);
        }
        public void ChangeToAppear()
        {
            //already appear, do nothing
        }

        public void ChangeToDisappear()
        {
            heart.state = new HeartDisappearState(heart);
        }
    }
}
