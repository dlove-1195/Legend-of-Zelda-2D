using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    class Sword:Iitem
    {
        public IMovingitemstate state;
        public ISprite swordSprite;
        //initial position which closed to Link
        public int posX;
        public int posY;
        

        public Sword()
        {
            state = new SwordAppearRightState(this);
        }
        public void Appear()
        {
            state.ChangeToAppear();
        }
        public void Disappear()
        {
            state.ChangeToDisappear();
        }
       public void Update() {
            swordSprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            swordSprite.Draw(spriteBatch, new Vector2(posX, posY));
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
