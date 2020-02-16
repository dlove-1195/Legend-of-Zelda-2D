using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    class BlueDiamond : Iitem
    {
        public IStaticitemstate state;
        public ISprite blueDiamondSprite;
        //initial position on the ground
        public int posX = 120;
        public int posY =400;
        public BlueDiamond()
        {
            state = new BlueDiamondAppearState(this);
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
            blueDiamondSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            blueDiamondSprite.Update();
        }

        public void nextItem()
        {
            Clock clock = new Clock();
        }

        public void preItem()
        {
            Heart heart = new Heart();
        }
    }
}
