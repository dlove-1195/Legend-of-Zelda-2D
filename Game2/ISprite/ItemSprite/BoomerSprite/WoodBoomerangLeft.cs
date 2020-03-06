using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class WoodBoomerangLeft : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX;
        private int posY;
        private int width;
        private int height;
        private int currentPos;
        private int gap = 0;
        private int boom = 0;
        private int totalBoom = 24;


        public WoodBoomerangLeft(Texture2D texture)
        {
            Texture = texture;
            currentPos = 0;
        }
        public WoodBoomerangLeft()
        {
            //do nothing
        }
        public void Update()
        {

            if (boom == 0)
            {
                posX = 4;
                posY = 3;
                width = 5;
                height = 8;
                currentPos = 0;
            }
            else if (boom == 2 * 2) //2
            {
                posX = 20;
                posY = 6;
                width = 9;
                height = 9;
                currentPos = 4 * 3;
            }
            else if (boom == 4 * 2) //3
            {
                posX = 37;
                posY = 4;
                width = 8;
                height = 5;
                currentPos = 8 * 3;
            }
            else if (boom == 6 * 2) //4
            {
                posX = 53;
                posY = 6;
                width = 9;
                height = 9;
                currentPos = 12 * 3;
            }
            else if (boom == 8 * 2) //5
            {
                posX = 73;
                posY = 3;
                width = 5;
                height = 8;
                currentPos = 16 * 3;
            }
            else if (boom == 10 * 2) //6
            {
                posX = 87;
                posY = 5;
                width = 9;
                height = 9;
                currentPos = 20 * 3;
            }
            else if (boom == 12 * 2) //7
            {
                posX = 105;
                posY = 5;
                width = 8;
                height = 5;
                currentPos = 24 * 3;
            }
            else if (boom == 14 * 2) //8
            {
                posX = 122;
                posY = 5;
                width = 9;
                height = 9;
                currentPos = 20 * 3;
            }
            else if (boom == 16 * 2) //1
            {
                posX = 4;
                posY = 3;
                width = 5;
                height = 8;
                currentPos = 16 * 3;
            }
            else if (boom == 18 * 2) //2
            {
                posX = 20;
                posY = 6;
                width = 9;
                height = 9;
                currentPos = 12 * 3;
                Console.WriteLine(currentPos);
            }
            else if (boom == 20 * 2) //3
            {
                posX = 37;
                posY = 4;
                width = 8;
                height = 5;
                currentPos = 8 * 3;
            }
            else if (boom == 22 * 2) //4
            {
                posX = 53;
                posY = 6;
                width = 9;
                height = 9;
                currentPos = 4 * 3;
            }

            else if (boom == totalBoom * 2) //9 return boom
            {
                posX = 4;
                posY = 3;
                width = 5;
                height = 8;
                currentPos = 0;
            }

            boom++;
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(posX, posY, width, height);
                Rectangle destinationRectangle = new Rectangle((int)vector.X - currentPos, (int)vector.Y, width * 4, height * 4);    // determine location and demension of the current frame

               
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
               
            }
        }

    }
}