using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkAttackLeftSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX=30;
        private int posY=0;
        private int width=15;
        private int height=16;
        private int delay=0;
        private int totalDelay=25;

        public LinkAttackLeftSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update()
        {
            if (delay <= totalDelay / 5)
            {
                posX = 30;
                posY = 0;
                width = 15;
                height = 16;
            }


            if (delay > totalDelay/5 && delay < 2*totalDelay/5)
            {
                posX = 31;
                posY = 30;
                width = 14;
                height = 15;

            }
            if (delay >= 2*totalDelay /5 && delay< 3*totalDelay/5)
            {

                posX = 30;
                posY = 60;
                width = 15;
                height = 15;
            }

            if (delay >= 3* totalDelay / 5 && delay < 5*totalDelay/5)
            {

                posX = 24;
                posY = 90;
                width = 27;
                height = 15;
            }

            delay++;
            if (delay == totalDelay)
            {
                posX = 30;
                posY = 0;
                width = 15;
                height = 16;
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