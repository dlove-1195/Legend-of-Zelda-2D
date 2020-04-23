using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkStand : ISprite
    {
        private Texture2D Texture;
        private int sourceLocX;
        private int sourceLocY;
        private int width;
        private int height;
        private string direction;

        public LinkStand(Texture2D texture, string d)
        {
            direction = d;
            Texture = texture;
            if (direction.Equals("Down"))
            {

                sourceLocX = 0;
                sourceLocY = 0;
                width = 15;
                height = 16;
            }
            else if (direction.Equals("Left"))
            {
                sourceLocX = 30;
                sourceLocY = 0;
                width = 15;
                height = 16;
            }
            else if (direction.Equals("Right"))
            {
                sourceLocX = 90;
                sourceLocY = 30;
                width = 15;
                height = 16;
            }
            else if (direction.Equals("Up")) {
                sourceLocX = 62;
                sourceLocY = 0;
                width = 15;
                height = 16;
            }
        }


        public void Update()
        {
            //no code 
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width * 3, height * 3);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

        }
    }
}
