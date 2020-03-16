using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class Bow : Iitem
    {
        public int itemNum = 3;
        public IitemState state;
        public ISprite bowSprite;
        //initial position which closed to Link
        public int posX;
        public int posY;

        private int delay = 0;
        private int facingDirection;

        private int bowWidth = 16;//sprite width
        private int bowHeight = 8;//sprite height
        public Rectangle boundingBox { get; set; }
        public Bow(int posX, int posY, int direction)
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
            this.bowSprite = sprite;
        }

        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, bowWidth * 3, bowHeight * 3);
            if (bowSprite != null)
            {
                bowSprite.Update();
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
            if (bowSprite != null)
            {
                bowSprite.Draw(spriteBatch, new Vector2(posX, posY));
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
