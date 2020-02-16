using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkAttackUpSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX;
        private int posY;
        private int width;
        private int height;
        private int currentFrame;
        private int totalFrames;

        public LinkAttackUpSprite(Texture2D texture)
        {
            Texture = texture;
            currentFrame = 0;
            totalFrames = 40;
            posX = 60;
            posY = 60;
            width = 16;
            height = 16;

        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames/20)
            {
                posX = 60;
                posY = 84;
                width = 16;
                height = 28;

            }
            if (currentFrame == totalFrames)
            {
                posX = 60;
                posY = 60;
                width = 16;
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
