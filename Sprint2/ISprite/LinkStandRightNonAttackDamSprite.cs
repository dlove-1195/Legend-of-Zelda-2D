using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkStandRightNonAttackDamageSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX;
        private int posY;
        private int width;
        private int height;
        private int currentFrame;
        private int totalFrames;
        private int desWidth;
        private int desHeight;

        public LinkStandRightNonAttackDamageSprite(Texture2D texture)
        {
            Texture = texture;
            currentFrame = 0;
            totalFrames = 80;
            posX = 90;
            posY = 30;
            width = 15;
            height = 16;
            desWidth = width * 3;
            desHeight = height * 3;

        }

        public void Update()
        {
            if (currentFrame < totalFrames)
            {
                if (currentFrame % 4 == 0)
                {
                    desWidth = 0;
                    desHeight = 0;

                }
                else {
                    desWidth = width * 3;
                    desHeight = height * 3;
                }
            }
            currentFrame++;

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            Rectangle sourceRectangle = new Rectangle(posX, posY, width, height);     
            Rectangle destinationRectangle = new Rectangle((int)vector.X, (int)vector.Y, desWidth, desHeight);    // determine location and demension of the current frame

            spriteBatch.Begin();
            
      
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

    }
}
