    
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    class ClockSprite: ISprite
    {
        public Texture2D Texture;
        private int sourceLocX = 362;
        private int sourceLocY = 0;
        private int width = 11;
        private int height = 16;

       
        public ClockSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public ClockSprite()
        {
            //another constructor, show nothing
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
                Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width * 3, height * 3);
                 

                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                 
            }
        }

        public void Update()
        {
            //nothing to update
        }
    }
}
