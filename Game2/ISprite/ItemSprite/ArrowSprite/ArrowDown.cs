using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ArrowDown : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX = 5;
        private int posY = 0;
        private int width = 5;
        private int height = 16;
        private int currentPos;
        private int gap = 13;


        public ArrowDown(Texture2D texture)
        {
            Texture = texture;
            currentPos = 0;
        }
        public ArrowDown()
        {
            //do nothing
        }

        public void Update()
        {
            currentPos += 7;



        }

        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(posX, posY, width, height);
                Rectangle destinationRectangle = new Rectangle((int)vector.X + gap, (int)vector.Y + currentPos, width * 3, height * 3);    // determine location and demension of the current frame

                spriteBatch.Begin();
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                spriteBatch.End();
            }
        }

    }
}