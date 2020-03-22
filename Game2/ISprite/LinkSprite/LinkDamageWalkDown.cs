using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkDamageWalkDownSprite : ISprite
    {
        public Texture2D Texture;
        private int sourceLocX = 77;
        private int sourceLocY = 1;
        private int width = 15;
        private int height = 16;
        private int blinkTimes = 0;
        private int totalBlink = 10;
        private int delay = 0;
        private int totalDelay = 30;
 
        public LinkDamageWalkDownSprite(Texture2D texture)
        {
            Texture = texture;
        }


        public void Update()
        {
            if (delay < totalDelay / 2)
            {
                width = 13;
                height = 16;
                if (blinkTimes == 0)
                {
                    sourceLocX = 96;
                    sourceLocY = 1;
                }
                else if (blinkTimes == 1)
                {
                    sourceLocX = 96;
                    sourceLocY = 145;
                }
                else if (blinkTimes == 2)
                {
                    sourceLocX = 96;
                    sourceLocY = 109;
                }
                else if (blinkTimes == 3)
                {
                    sourceLocX = 96;
                    sourceLocY = 127;
                }
                else if (blinkTimes == 4)
                {
                    sourceLocX = 96;
                    sourceLocY = 145;
                }
            }
            else
            {
                width = 15;
                height = 16;
                if (blinkTimes == 5)
                {
                    sourceLocX = 77;
                    sourceLocY = 1;
                }
                else if (blinkTimes == 6)
                {
                    sourceLocX = 77;
                    sourceLocY = 145;
                }
                else if (blinkTimes == 7)
                {
                    sourceLocX = 77;
                    sourceLocY = 127;
                }
                else if (blinkTimes == 8)
                {
                    sourceLocX = 77;
                    sourceLocY = 1;
                }
                else if (blinkTimes == 9)
                {
                    sourceLocX = 77;
                    sourceLocY = 145;
                }

            }
            delay++;
            blinkTimes++;
            if (delay == totalDelay)
            {
                delay = 0;
            }
            if (blinkTimes == totalBlink)
            {
                blinkTimes = 0;
            }

            
                Link.posY++;
            
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
            Rectangle destinationRectangle = new Rectangle( Link.posX, Link.posY, width * 3, height * 3);

           
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
           
        }
    }
}
