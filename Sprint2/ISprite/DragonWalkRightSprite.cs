using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class DragonWalkRightSprite : ISprite
    {
        public Texture2D Texture;
        private int width = 24;
        private int height = 32;

        private int currentFrame = 0;
        private int totalFrames = 3;
        private int delay = 0;
        private int totalDelay = 3;
        private int posX = 400;
        private int posY = 200;

        private bool movingRight = true;

        public DragonWalkRightSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update()
        {
            delay++;
            if (delay == totalDelay)
            {
                currentFrame++;
                delay = 0;
            }

            if (currentFrame == totalFrames) { currentFrame = 0; }

            if (movingRight)
            {
                posX++;
                
                if (posX == 700)
                    movingRight = false;
            }
            else
            {
                //doNothing
            }

        }



        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            int sourceLocY = 0;
            int sourceLocX = currentFrame * 45 +4;
            Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
            Rectangle destinationRectangle = new Rectangle(posX, posY, width * 3, height * 3);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
