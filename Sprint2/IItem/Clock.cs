using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    class Clock : Iitem
    {
        public IStaticitemstate state;
        public ISprite clockSprite;
        //initial position on the ground
        public int posX =120;
        public int posY= 400;
        public Clock()
        {
            state = new ClockAppearState(this);
        }
        public void Appear()
        {
            state.ChangeToAppear();
        }

        public void Disappear()
        {
            state.ChangeToDisappear();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            clockSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            clockSprite.Update();
        }
      

        public void preItem()
        {
            BlueDiamond blueDiamond = new BlueDiamond();
        }
        public void nextItem()
        {
            Heart heart = new Heart();
        }
    }
}
