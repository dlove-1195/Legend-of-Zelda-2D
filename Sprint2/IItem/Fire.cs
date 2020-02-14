using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    class Fire : Iitem
    {
        public Iitemstate state;
        public ISprite fireSprite;
        //initial position closed to dragon
        public int posX;
        public int posY;
        public Fire()
        {
            //constructor,initialize state
        }
        public void Appear()
        {
            
        }

        public void Disappear()
        {
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            fireSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            fireSprite.Update();
        }
        public void goUp()
        {

        }
        public void goDown()
        {

        }
        public void goRight()
        {

        }
        public void goLeft()
        {

        }
    }
}
