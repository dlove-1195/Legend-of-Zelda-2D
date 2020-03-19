using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class Sword : Iitem
    {
        public int itemNum = 4;
        public IitemState state;
        public ISprite swordSprite;
        //initial position which closed to Link
        public int posX { get; set; }
        public int posY { get; set; }


        private int swordWidth = 7;//sprite width
        private int swordHeight = 16;//sprite height
        public Rectangle boundingBox { get; set; }

        private int delay = 0;
        private int facingDirection;
        public Sword(int posX, int posY, int direction)
        {
           
            facingDirection = direction;
            this.posX = posX;
            this.posY = posY;


        }


        public void Update()
        {
            if (swordSprite != null)
            {
                boundingBox = new Rectangle(posX, posY, swordWidth * 3, swordHeight * 3);
                swordSprite.Update();
            }
            delay++;
            if (delay == 40)
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
            if (swordSprite != null)
            {
                swordSprite.Draw(spriteBatch, new Vector2(posX, posY));
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
 
        public void changeSprite(ISprite sprite)
        {
            this.swordSprite = sprite;
        }

        public int getItem()
        {
            return itemNum;
        }
    }
}
