using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkDamageWalkRightSprite : ISprite
    {
        public Texture2D Texture;
        private int sourceLocX = 131;
        private int sourceLocY = 2;
        private int width = 14;
        private int height = 15;
        private int blinkTimes = 0;
        private int totalBlink = 10;
        private int delay = 0;
        private int totalDelay = 10;

        private bool movingRight = true;

        public LinkDamageWalkRightSprite(Texture2D texture)
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
                    sourceLocX = 131;
                    sourceLocY = 2;
                }
                else if (blinkTimes == 1)
                {
                    sourceLocX = 131;
                    sourceLocY = 146;
                }
                else if (blinkTimes == 2)
                {
                    sourceLocX = 131;
                    sourceLocY = 110;
                }
                else if (blinkTimes == 3)
                {
                    sourceLocX = 131;
                    sourceLocY = 128;
                }
                else if (blinkTimes == 4)
                {
                    sourceLocX = 131;
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
                    sourceLocX = 149;
                    sourceLocY = 1;
                }
                else if (blinkTimes == 6)
                {
                    sourceLocX = 149;
                    sourceLocY = 145;
                }
                else if (blinkTimes == 7)
                {
                    sourceLocX = 149;
                    sourceLocY = 109;
                }
                else if (blinkTimes == 8)
                {
                    sourceLocX = 149;
                    sourceLocY = 127;
                }
                else if (blinkTimes == 9)
                {
                    sourceLocX = 149;
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
            if (movingRight)
            {
                Link.posX++;
                if (Link.posX >= Game1.WindowWidth - width * 3)
                    movingRight = false;
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

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
