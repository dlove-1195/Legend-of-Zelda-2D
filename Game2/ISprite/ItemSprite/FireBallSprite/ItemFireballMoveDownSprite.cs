using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class ItemFireballMoveDownSprite : ISprite
    {
        public Texture2D Texture;
        private int sourceLocX = 334;
        private int sourceLocY = 3;
        private int width = 8;
        private int height = 10;
        private int currentFrame = 0;


        public ItemFireballMoveDownSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public ItemFireballMoveDownSprite()
        {
            //another constructor, show nothing
        }

        public void Update()
        {
            currentFrame++;
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
                Rectangle destinationRectangle = new Rectangle((int)location.X , (int)location.Y + currentFrame * 3, width * 3, height * 3);
                //spriteBatch.Begin();

                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                //spriteBatch.End();
            }
        }


    }
}
