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
        public Iitemstate state;
        public ISprite clockSprite;
        //initial position on the ground
        public int posX;
        public int posY;
        public Clock()
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
            clockSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            clockSprite.Update();
        }
        public void goUp()
        {
            //clock stand still, do nothing
        }
        public void goDown()
        {
            //clock stand still, do nothing
        }
        public void goRight()
        {
            //clock stand still, do nothing
        }
        public void goLeft()
        {
            //clock stand still, do nothing
        }
    }
}
