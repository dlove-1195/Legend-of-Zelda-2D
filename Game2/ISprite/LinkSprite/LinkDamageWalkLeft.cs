using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkDamageWalkLeftSprite : ISprite
    {
        public Texture2D Texture;
        private int sourceLocX = 589;
        private int sourceLocY = 2;
        private int width = 14;
        private int height = 15;
        private int blinkTimes = 0;
        private int totalBlink = 10;
        private int delay = 0;
        private int totalDelay = 10;
        private bool movingLeft = true;

        public LinkDamageWalkLeftSprite(Texture2D texture)
        {
            Texture = texture;
        }


        public void Update()
        {
            if (delay <= totalDelay / 2)
            {
                width = 14;
                height = 15;
                if (blinkTimes == 0)
                {
                    sourceLocX = 589;
                    sourceLocY = 2;
                }
                else if (blinkTimes == 1)
                {
                    sourceLocX = 589;
                    sourceLocY = 146;
                }
                else if (blinkTimes == 2)
                {
                    sourceLocX = 589;
                    sourceLocY = 110;
                }
                else if (blinkTimes == 3)
                {
                    sourceLocX = 589;
                    sourceLocY = 128;
                }
                else if (blinkTimes == 4)
                {
                    sourceLocX = 589;
                    sourceLocY = 146;
                }
                if (delay == totalDelay)
                {
                    delay = 0;
                }
            }
            else
            {
                width = 15;
                height = 16;
                if (blinkTimes == 5)
                {
                    sourceLocX = 570;
                    sourceLocY = 1;
                }
                else if (blinkTimes == 6)
                {
                    sourceLocX = 570;
                    sourceLocY = 145;
                }
                else if (blinkTimes == 7)
                {
                    sourceLocX = 570;
                    sourceLocY = 109;
                }
                else if (blinkTimes == 8)
                {
                    sourceLocX = 570;
                    sourceLocY = 127;
                }
                else if (blinkTimes == 9)
                {
                    sourceLocX = 570;
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

            //moving left and right 
            if (movingLeft)
            {
                Link.posX--;
                if (Link.posX <= 0)
                    movingLeft = false;
            }
            else
            {
                //doNothing
            }


        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {

            Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
            Rectangle destinationRectangle = new Rectangle(Link.posX, Link.posY, width * 3, height * 3);

            
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
             
        }
    }
}
