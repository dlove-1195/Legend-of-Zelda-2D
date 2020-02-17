using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class Sword: Iitem
    {
        public IMovingitemstate state;
        public ISprite swordSprite;
        //initial position which closed to Link
        public int posX;
        public int posY;
        private int delay= 0; 

        public Sword(int posX, int posY, int direction)
        {
            switch (direction)
            {
                case 0:
                    state = new SwordAppearUpState(this);
                    break;
                case 1:
                    state = new SwordAppearDownState(this);
                    break;
                case 2:
                    state = new SwordAppearLeftState(this);
                    break;
                case 3:
                    state = new SwordAppearRightState(this);
                    break;
                default:
                    Console.WriteLine("error: no such situation");
                    break;
            }
            this.posX = posX;
            this.posY = posY;
            
        }
        
        public void Update() {
            swordSprite.Update();
            int totalDelay = 30;
          
                delay++;
                if(delay == totalDelay)
                {
                    
                    state.ChangeToDisappear();
                }
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
