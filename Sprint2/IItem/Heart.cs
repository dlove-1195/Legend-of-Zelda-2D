using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace Sprint2
{
    class Heart : Iitem
    {
        public Iitemstate state;
        public ISprite heartSprite;
        //initial position in the center
        public int posX =250;
        public int posY =200;

        public Heart()
        {
            //constructor, initialize state
        }
        public void Appear()
        {
            
        }

        public void Disappear()
        {
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            heartSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            heartSprite.Update();
        }
        public void goUp()
        {
            //heart stands still, do nothing
        }
        public void goDown()
        {
            //hearts stands still, do nothing
        }
        public void goRight()
        {
            //hearts stands still, do nothing
        }
        public void goLeft()
        {
            //hearts stands still, do nothing
        }
    }
}
