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
        public IMovingitemstate state;
        public ISprite fireSprite;
        //initial position closed to dragon
        public int posX;
        public int posY;
        public Fire()
        {
            state = new FireAppearLeftState(this);
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
            fireSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            fireSprite.Update();
        }
        public void goUp()
        {
            state.ChangeToUp();
        }
        public void goDown()
        {
            state.ChangeToDown();
        }
        public void goRight()
        {
            state.ChangeToRight();
        }
        public void goLeft()
        {
            state.ChangeToLeft();
        }
        public void preItem()
        {
            //nothing
        }
        public void nextItem()
        {
            //nothing
        }
    }
}
