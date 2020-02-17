using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkAttackRightSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX=91;
        private int posY=0;
        private int width=14;
        private int height=15;
        private int delay=0;
        private int totalDelay=25;

        public LinkAttackRightSprite(Texture2D texture)
        {
            Texture = texture;
           
        }

        public void Update()
        {
            if (delay <= totalDelay / 5)
            {
                posX = 91;
                posY = 0;
                width = 14;
                height = 15;

            }
            if (delay > totalDelay / 5 && delay < 2 * totalDelay / 5)
            {
                posX = 90;
                posY = 30;
                width = 15;
                height = 16;

            }
            if (delay >= 2 * totalDelay / 5 && delay < 3 * totalDelay / 5)
            {

                posX = 90;
                posY = 60;
                width = 15;
                height = 15;
            }

            if (delay >= 3 * totalDelay / 5 && delay < 5 * totalDelay / 5)
            {

                posX = 84;
                posY = 90;
                width = 27;
                height = 15;
            }
            delay++;
            if (delay == totalDelay)
            {
                delay = 0;
            }


        }

        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            Rectangle sourceRectangle = new Rectangle(posX, posY, width, height);     // determine which frame
            Rectangle destinationRectangle = new Rectangle((int)vector.X, (int)vector.Y, width * 3, height * 3);    // determine location and demension of the current frame

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

    }
} 
