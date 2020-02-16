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
        private int posX;
        private int posY;
        private int width;
        private int height;
        private int currentFrame;
        private int totalFrames;

        public LinkAttackRightSprite(Texture2D texture)
        {
            Texture = texture;
            currentFrame = 0;
            totalFrames = 40;
            posX = 90;
            posY = 80;
            width = 15;
            height = 15;

        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames / 20)
            {
                posX = 84;
                posY = 90;
                width = 27;
                height = 15;

            }
            if (currentFrame == totalFrames)
            {
                posX = 90;
                posY = 30;
                width = 15;
                height = 16;
                Link.currentFrame = 40;
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
