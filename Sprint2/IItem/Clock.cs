using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Clock : Iitem
    {
        public IitemState state;
        public ISprite clockSprite;
        //initial position on the ground
        public int posX =120;
        public int posY= 400;
         
        public Clock()
        {
            state = new ClockAppearState(this);
        }
         

        public void Draw(SpriteBatch spriteBatch)
        {
            clockSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            clockSprite.Update();
        }
      

        public void preItem(Game1 myGame)
        {
            //state.ChangeToDisappear();
            myGame.item = new BlueDiamond();
        }
        public void nextItem(Game1 myGame)
        {
            //state.ChangeToDisappear();
            myGame.item = new Heart();
        }
    }
}
