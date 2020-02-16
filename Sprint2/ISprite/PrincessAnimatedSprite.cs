using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class PrincessAnimatedSprite : ISprite
    {
        public Texture2D Texture;
        private int width = 14;
        private int height = 26;

        private int currentFrame = 0;
        private int totalFrames = 1;
        private int delay = 0;
        private int totalDelay = 1;



        public PrincessAnimatedSprite(Texture2D texture)
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

        }



        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            int sourceLocY = 0;
            int sourceLocX = currentFrame * 30 + 151;
            Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
            Rectangle destinationRectangle = new Rectangle(Dragon.posX, Dragon.posY, width * 3, height * 3);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}