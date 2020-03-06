using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class BlueCandle : Iitem
    {
        public int itemNum = 1;
        public IitemState state;
        public ISprite blueCandleSprite;
        //initial position which closed to Link
        public int posX;
        public int posY;

        private int delay = 0;
        private int facingDirection;

        private int bluecandleWidth = 8;//sprite width
        private int bluecandleHeight = 16;//sprite height
        public Rectangle boundingBox { get; set; }

        public BlueCandle(int posX, int posY, int direction)
        {
            state = new DisappearState(this);

            facingDirection = direction;
            this.posX = posX;
            this.posY = posY;


        }
        public int getItem()
        {
            return itemNum;
        }
        public void changeState(IitemState state)
        {
            this.state = state;
        }
        public void changeSprite(ISprite sprite)
        {
            this.blueCandleSprite = sprite;
        }


        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, bluecandleWidth * 3, bluecandleHeight * 3);
            blueCandleSprite.Update();

            int totalDelay = 100;

            delay++;

            switch (facingDirection)
            {
                case 0:
                    state = new AppearUpState(this);
                    break;
                case 1:
                    state = new AppearDownState(this);
                    break;
                case 2:
                    state = new AppearLeftState(this);
                    break;
                case 3:
                    state = new AppearRightState(this);
                    break;
                default:
                    Console.WriteLine("error: no such situation");
                    break;
            }



            if (delay >= totalDelay)
            {
                boundingBox = new Rectangle(0, 0, 0, 0);
                state.ChangeToDisappear();
            }

        }


        public void Draw(SpriteBatch spriteBatch)
        {

            blueCandleSprite.Draw(spriteBatch, new Vector2(posX, posY));

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
