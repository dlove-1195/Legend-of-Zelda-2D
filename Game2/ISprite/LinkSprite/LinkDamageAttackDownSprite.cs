using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkDamageAttackDownSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        private int sourceLocX = 239;
        private int sourceLocY = 1;
        private int width = 16;
        private int height = 15;
        private int totalBlink = 6;
        private int blinkTimes = 0;
        private int delay = 0;
        private int totalDelay = 60;
        private Texture2D sword = Texture2DStorage.GetHurtWeaponSpriteSheet();

        public LinkDamageAttackDownSprite(Texture2D texture)
        {
            Texture = texture;


        }
        public LinkDamageAttackDownSprite()
        {
            //do nothing


        }
        public void Update()
        {

            if (delay <= totalDelay/2)
            {
                width = 16;
                height = 15;
                if (blinkTimes == 0)
                {
                    sourceLocX = 239;
                    sourceLocY = 145;
                }
                else if (blinkTimes == 1)
                {
                    sourceLocX = 239;
                    sourceLocY = 91;
                }
                else if (blinkTimes == 2)
                {
                    sourceLocX = 239;
                    sourceLocY = 127;
                }
                else if (blinkTimes == 3)
                {
                    sourceLocX = 239;
                    sourceLocY = 253;
                }
                else if (blinkTimes == 4)
                {
                    sourceLocX = 239;
                    sourceLocY = 37;
                }
                else if (blinkTimes == 5)
                {
                    sourceLocX = 239;
                    sourceLocY = 271;
                }

            }
            
            else if (delay > totalDelay/2)
            {
                width = 15;
                height = 16;
                if ((blinkTimes == 6)|| (blinkTimes == 0))
                {
                    sourceLocX = 77;
                    sourceLocY = 1;
                }
                else if ((blinkTimes == 7) || (blinkTimes ==1))
                {
                    sourceLocX = 77;
                    sourceLocY = 145;
                }
                if ((blinkTimes == 8) || (blinkTimes == 2))
                {
                    sourceLocX = 77;
                    sourceLocY = 109;
                }
                else if ((blinkTimes == 9) || (blinkTimes == 3))
                {
                    sourceLocX = 77;
                    sourceLocY = 127;
                }
                else if ((blinkTimes == 10) || (blinkTimes == 4))
                {
                    sourceLocX = 77;
                    sourceLocY = 145;
                }
                else if ((blinkTimes == 11) || (blinkTimes == 5))
                {
                    sourceLocX = 77;
                    sourceLocY = 1;
                }
            }
            delay++;
            blinkTimes++;

            if (blinkTimes == totalBlink)
            {
                blinkTimes = 0;
            }
            /*
            if (delay == totalDelay)
            {
                delay = 0;
            }*/


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
                Rectangle swordsourceRectangle = new Rectangle(152, 4, 7, 16);
                Rectangle sworddestinationRectangle = new Rectangle((int)vector.X + 15, (int)vector.Y + 35, 7 * 3, 16 * 3);

                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                if (delay <= totalDelay / 2)
                {
                    
                    spriteBatch.Draw(sword, sworddestinationRectangle, swordsourceRectangle, Color.White);
                }

            }
        }

    }
}
