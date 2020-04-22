using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkDamageAttackRightSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        private int sourceLocX = 131;
        private int sourceLocY = 254;
        private int width = 14;
        private int height = 15;
        private int totalBlink = 5;
        private int blinkTimes = 0;
        private int delay = 0;
        private int totalDelay = 60;

        public LinkDamageAttackRightSprite(Texture2D texture)
        {
            Texture = texture;


        }
        public LinkDamageAttackRightSprite()
        {
            //do nothing


        }
        public void Update()
        {

            if (delay <= totalDelay/2)
            {
                width = 14;
                height = 15;
                if (blinkTimes == 0)
                {
                    sourceLocX = 131;
                    sourceLocY = 254;
                }
                else if (blinkTimes == 1)
                {
                    sourceLocX = 131;
                    sourceLocY = 38;
                }
                else if (blinkTimes == 2)
                {
                    sourceLocX = 131;
                    sourceLocY = 128;
                }
                else if (blinkTimes == 3)
                {
                    sourceLocX = 131;
                    sourceLocY = 146;
                }
                else if (blinkTimes == 4)
                {
                    sourceLocX = 131;
                    sourceLocY = 182;
                }
                else if (blinkTimes == 5)
                {
                    sourceLocX = 131;
                    sourceLocY = 272;
                }

            }
            else if (delay > totalDelay / 2)
            {
                width = 15;
                height = 16;
                if ((blinkTimes == 6) || (blinkTimes == 0))
                {
                    sourceLocX = 149;
                    sourceLocY = 109;
                }
                else if ((blinkTimes == 7) || (blinkTimes == 1))
                {
                    sourceLocX = 149;
                    sourceLocY = 127;
                }
                if ((blinkTimes == 8) || (blinkTimes == 2))
                {
                    sourceLocX = 149;
                    sourceLocY = 145;
                }
                else if ((blinkTimes == 9) || (blinkTimes == 3))
                {
                    sourceLocX = 149;
                    sourceLocY = 271;
                }
                else if ((blinkTimes == 10) || (blinkTimes == 4))
                {
                    sourceLocX = 149;
                    sourceLocY = 181;
                }
            }
            delay++;
            blinkTimes++;

            if (blinkTimes == totalBlink)
            {
                blinkTimes = 0;
            }
             

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);     // determine which frame
                Rectangle destinationRectangle = new Rectangle((int)vector.X, (int)vector.Y, width * 3, height * 3);    // determine location and demension of the current frame
                Rectangle swordsourceRectangle = new Rectangle(329, 132, 16, 7);     // determine which frame
                Rectangle sworddestinationRectangle = new Rectangle((int)vector.X + 30, (int)vector.Y + 16, 16 * 3, 7 * 3);    // determine location and demension of the current frame

                if (delay <= totalDelay / 2)
                {
                    spriteBatch.Draw(Texture, sworddestinationRectangle, swordsourceRectangle, Color.White);
                }

                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

            }
        }

    }
}
