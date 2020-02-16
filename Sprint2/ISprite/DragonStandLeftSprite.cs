using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class DragonStandLeftSprite : ISprite
    {
        public Texture2D Texture;
        private int sourceLocX = 25;
        private int sourceLocY = 91;
        private int width = 28;
        private int height = 15;

        //Test for enemies sprites, delete later

        public DragonStandLeftSprite(Texture2D texture)
        {
            Texture = texture;
        }
        public DragonStandLeftSprite()
        {
            //do nothing
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
            //do nothing
        }
    }
}
