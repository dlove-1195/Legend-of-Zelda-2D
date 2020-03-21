using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class Fire : Iitem
    {
        public int count { get; set; } = 0;
        public int totalCount { get; set; } = 100;
        public bool appear { get; set; } = false;
        public int itemNum = 15;
        public IitemState state;
        public static ISprite fireSprite;
        //initial position which closed to Link
        public int posX { get; set; }
        public int posY { get; set; }

        private int fireWidth = 8;//sprite width
        private int fireHeight = 10;//sprite height
        public Rectangle boundingBox { get; set; }

        
        public Fire(int posX, int posY, int direction)
        {

            switch (direction)
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



            this.posX = posX;
            this.posY = posY;


        }
        public int getItem()
        {
            return itemNum;
        }
       
        public void changeSprite(ISprite sprite)
        {
            fireSprite = sprite;
        }

        public void Update()
        {

            if (fireSprite != null)
            {
                boundingBox = new Rectangle(posX, posY, fireWidth * 3, fireHeight * 3);
                fireSprite.Update();

            }
    
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            if (fireSprite != null)
            {
                fireSprite.Draw(spriteBatch, new Vector2(posX, posY));
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
