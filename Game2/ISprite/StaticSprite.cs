 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class StaticSprite : ISprite
    {
        public Texture2D Texture;
        private int width;
        private int height;

        private int sourceLocX;
        private int sourceLocY;



        public StaticSprite(Texture2D texture, int posX, int posY, int sprite_width, int sprite_height)
        {
            Texture = texture;
            sourceLocX = posX;
            sourceLocY = posY;
            width = sprite_width;
            height = sprite_height;

        }
        public StaticSprite()
        {
            //do nothing
        }

        public void Update()
        {
            //do nothing

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
                Rectangle destinationRectangle = new Rectangle((int)vector.X, (int)vector.Y, width * 3, height * 3);

                spriteBatch.Begin();
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                spriteBatch.End();

            }
        }
    }
}