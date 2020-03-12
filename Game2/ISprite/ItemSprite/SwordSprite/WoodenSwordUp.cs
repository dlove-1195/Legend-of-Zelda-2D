using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class WoodenSwordUp : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX = 64;
        private int posY = 195;
        private int width = 7;
        private int height = 16;
        private int currentPos;
        private int gap = 9;


        public WoodenSwordUp(Texture2D texture)
        {
            Texture = texture;
            currentPos = 0;
        }
        public WoodenSwordUp()
        {
            //do nothing
        }
        public void Update()
        {
            currentPos -= 7;
            

            
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(posX, posY, width, height);
                Rectangle destinationRectangle = new Rectangle((int)vector.X + gap, (int)vector.Y + currentPos, width * 3, height * 3);    // determine location and demension of the current frame

                 
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                 
            }
        }

    }
}
