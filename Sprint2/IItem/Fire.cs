using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Fire : Iitem
    {
        public IMovingitemstate state;
        public ISprite fireSprite;
        private int delay = 0;
        //initial position closed to dragon
        private int posX;
        private int posY;
        public Fire(int posX, int posY, int direction)
        {
            this.posX = posX;
            this.posY = posY;
            state = new FireAppearLeftState(this);
            switch (direction)
            {
                case 0:
                    state = new FireAppearUpState(this);
                    break;
                case 1:
                    state = new FireAppearDownState(this);
                    break;
                case 2:
                    state = new FireAppearLeftState(this);
                    break;
                case 3:
                    state = new FireAppearRightState(this);
                    break;
                default:
                    Console.WriteLine("error: no such situation");
                    break;
            }
        }
       

        public void Draw(SpriteBatch spriteBatch)
        {
            fireSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            fireSprite.Update();
            int totalDelay = 30;

            delay++;
            if (delay == totalDelay)
            {

                state.ChangeToDisappear();
            }


        }
      /*  public void goUp()
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
        } */
        public void preItem(Game1 myGame)
        {
            //nothing
        }
        public void nextItem(Game1 myGame)
        {
            //nothing
        }
    }
}
