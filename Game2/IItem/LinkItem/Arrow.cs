using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class Arrow : Iitem
    {
        public int itemNum = 0;
        public IitemState state;
        public ISprite arrowSprite;
        //initial position which closed to Link
        public int posX { get; set; }
        public int posY { get; set; }


        private int delay = 0;
        private int facingDirection;

        private int arrowWidth = 5;//sprite width
        private int arrowHeight = 16;//sprite height
        public Rectangle boundingBox { get; set; }

        public static Iitem bow;
        public Arrow(int posX, int posY, int direction)
        {
            
            facingDirection = direction;
    
                this.posX = posX;
                this.posY = posY;
 
        }
        public int getItem()
        {
            return itemNum;
        }
      
        public void changeSprite(ISprite sprite)
        {
            this.arrowSprite = sprite;
        }

        public void Update()
        {
                
              delay++;
            if (bow != null)
            {
                bow.Update();
            }
        if (delay >= 20)
        {
                if (delay >= 30)
                {
                    bow = null;
                }
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

        }


            if (arrowSprite != null)
            {
                boundingBox = new Rectangle(posX, posY, arrowWidth * 3, arrowHeight * 3);
                arrowSprite.Update();
            }
          }


        public void Draw(SpriteBatch spriteBatch)
        {
            if (arrowSprite != null)
            {
                arrowSprite.Draw(spriteBatch, new Vector2(posX, posY));
                 
            }

            if (bow != null)
            {
                bow.Draw(spriteBatch);
            }
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
