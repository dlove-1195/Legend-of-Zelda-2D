using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class WoodenBoomerang : Iitem
    {
        public int itemNum = 5;
        public IitemState state;
        public ISprite woodenBoomerangSprite;
        //initial position which closed to Link
        public int posX { get; set; }
        public int posY { get; set; }


        private int delay = 0;
        private int facingDirection;

        private int boomerWidth = 9;//sprite width
        private int boomerHeight = 9;//sprite height
        public Rectangle boundingBox { get; set; }

        public WoodenBoomerang(int posX, int posY, int direction)
        {
            boundingBox = new Rectangle(0, 0, 0, 0);
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
            this.woodenBoomerangSprite = sprite;
        }

        public void Update()
        {
            if (woodenBoomerangSprite != null)
            {
                boundingBox = new Rectangle(posX, posY, boomerWidth * 3, boomerHeight * 3);
                woodenBoomerangSprite.Update();
            }
 
            delay++;
            if (delay == 10)
            {
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
            

        }


        public void Draw(SpriteBatch spriteBatch)
        {
            if (woodenBoomerangSprite != null)
            {
                woodenBoomerangSprite.Draw(spriteBatch, new Vector2(posX, posY));
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
