using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkDamageStandDownSprite : ISprite
    {
        private Texture2D Texture;
        private int sourceLocX = 77;
        private int sourceLocY = 1;
        private int width = 15;
        private int height = 16;
        private int blinkTimes = 0;
        private int totalBlink = 5;
 
        public LinkDamageStandDownSprite(Texture2D texture)
        {
            Texture = texture;
        }


        public void Update()
        {
         
                if (blinkTimes == 0)
                {

                    sourceLocY = 1;
                }
                else if (blinkTimes == 1)
                {

                    sourceLocY = 145;
                }
                else if (blinkTimes == 2)
                {

                    sourceLocY = 109;
                }
                else if (blinkTimes == 3)
                {

                    sourceLocY = 127;
                }
                else if (blinkTimes == 4)
                {

                    sourceLocY = 145;
                }


                blinkTimes++;
                if (blinkTimes == totalBlink)
                {
    
                    blinkTimes = 0;
                }

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width * 3, height * 3);
         
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            
        }
    }
}
