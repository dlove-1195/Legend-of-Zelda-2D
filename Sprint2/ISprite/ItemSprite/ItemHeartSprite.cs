using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    class ItemHeartSprite : ISprite
    {
        public Texture2D Texture;
        private int sourceLocX = 241;
        private int sourceLocY = 41;
        private int width = 13;
        private int height = 13;


        public ItemHeartSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public ItemHeartSprite()
        {
            //another constructor, show nothing
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
                Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width * 3, height * 3);
                spriteBatch.Begin();

                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                spriteBatch.End();
            }
        }

        public void Update()
        {
            //nothing to update
        }
    }
}
