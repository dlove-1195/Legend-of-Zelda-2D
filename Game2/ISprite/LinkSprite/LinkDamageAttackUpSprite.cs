using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkDamageAttackUpSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        private int sourceLocX = 257;
        private int sourceLocY = 1;
        private int width=16;
        private int height=16;
        private int totalBlink = 6;
        private int blinkTimes=0;
        private int delay = 0;
        private int totalDelay = 60;

        public LinkDamageAttackUpSprite(Texture2D texture)
        {
            Texture = texture;
       

        }
        public LinkDamageAttackUpSprite()
        {
            //do nothing


        }
        public void Update()
        {

            if (delay < totalDelay)
            {
                width = 16;
                height = 16;
                if (blinkTimes == 0)
                {
                    sourceLocX = 257;
                    sourceLocY = 145;
                }
                else if (blinkTimes == 1)
                {
                    sourceLocX = 257;
                    sourceLocY = 91;
                }
                else if (blinkTimes == 2)
                {
                    sourceLocX = 257;
                    sourceLocY = 127;
                }else if(blinkTimes == 3)
                {
                    sourceLocX = 257;
                    sourceLocY = 253;
                }
                else if (blinkTimes == 4)
                {
                    sourceLocX = 257;
                    sourceLocY = 37;
                }
                else if (blinkTimes == 5)
                {
                    sourceLocX = 257;
                    sourceLocY = 271;
                }

            }
            /*
            else if (delay < totalDelay*2)
            {
                width = 12;
                height = 16;
                if ((blinkTimes == 6)|| (blinkTimes == 0))
                {
                    sourceLocX = 115;
                    sourceLocY = 1;
                }
                else if ((blinkTimes == 7) || (blinkTimes ==1))
                {
                    sourceLocX = 115;
                    sourceLocY = 145;
                }
                if ((blinkTimes == 8) || (blinkTimes == 2))
                {
                    sourceLocX = 115;
                    sourceLocY = 109;
                }
                else if ((blinkTimes == 9) || (blinkTimes == 3))
                {
                    sourceLocX = 115;
                    sourceLocY = 127;
                }
                else if ((blinkTimes == 10) || (blinkTimes == 4))
                {
                    sourceLocX = 115;
                    sourceLocY = 145;
                }
            }*/
            delay++;
            blinkTimes++;
           
            if (blinkTimes == totalBlink)
            {
                blinkTimes = 0;
            }
            if (delay == totalDelay)
            {
                delay = 0;
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

                
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                 
            }
        }

    }
} 
