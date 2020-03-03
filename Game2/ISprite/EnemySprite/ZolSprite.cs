using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ZolSprite : ISprite
    {
        private Texture2D Texture;
        private string Direction;
        private int sourceLocX = 818;
        private int sourceLocY = 8;
        private int width = 11;
        private int height = 15;
        private int delay = 0;
        private int totalDelay = 30;
        private int i = 4;
        private int j = 0;
        private bool movingDirection = true;


        public ZolSprite(Texture2D texture, string direction)
        {
            Texture = texture;
            Direction = direction;
        }
        public ZolSprite()
        {
            //do nothing
        }

        public void Update()
        {
            if (delay > totalDelay / 2)
            {

                width = 13;
                height = 13;
                sourceLocX = 794;
                sourceLocY = 10;
                i = 0;
                j = 6;
                if (delay == totalDelay)
                {
                    delay = 0;
                }
            }
            else
            {
                width = 11;
                height = 15;
                sourceLocX = 818;
                sourceLocY = 8;
                i = 4;
                j = 0;
            }
            delay++;

            switch (Direction)
            {
                case "Right":
                    if (movingDirection)
                    {
                        Zol.posX++;

                        if (Zol.posX == 700)
                            movingDirection = false;
                    }
                    break;
                case "Left":
                    if (movingDirection)
                    {
                        Zol.posX--;

                        if (Zol.posX <= 0)
                            movingDirection = false;
                    }
                    break;
                case "Up":
                    if (movingDirection)
                    {
                        Zol.posY--;

                        if (Zol.posY <= 0)
                            movingDirection = false;
                    }
                    break;
                case "Down":
                    if (movingDirection)
                    {
                        Zol.posY++;

                        if (Zol.posY == 700)
                            movingDirection = false;
                    }
                    break;

            }
        }



        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
                Rectangle destinationRectangle = new Rectangle(Zol.posX + i, Zol.posY + j, width * 3, height * 3);
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            }
        }
    }
}