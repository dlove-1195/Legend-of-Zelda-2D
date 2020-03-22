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
        public int count { get; set; } = 0;
        public int totalCount { get; set; } = 100;
        public bool appear { get; set; } = false;

        private int itemNum = 1;
        private IItemState state;
        private ISprite blueCandleSprite;
        //initial position which closed to Link
        public int posX { get; set; }
        public int posY { get; set; }


        
        private int facingDirection;

        private int bluecandleWidth = 8;//sprite width
        private int bluecandleHeight = 16;//sprite height
        public Rectangle boundingBox { get; set; }

        public BlueCandle(int posX, int posY, int direction)
        {
            

            facingDirection = direction;
            this.posX = posX;
            this.posY = posY;

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
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                    Console.WriteLine("error: no such situation");
#pragma warning restore CA1303 // Do not pass literals as localized parameters
                    break;
            }



        }
        public int getItem()
        {
            return itemNum;
        }
       
        public void changeSprite(ISprite sprite)
        {
            this.blueCandleSprite = sprite;
        }


        public void Update()
        {
          
                boundingBox = new Rectangle(posX, posY, bluecandleWidth * 3, bluecandleHeight * 3);
                blueCandleSprite.Update();
         
           
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
