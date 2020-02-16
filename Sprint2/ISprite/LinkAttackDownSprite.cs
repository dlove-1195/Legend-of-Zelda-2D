﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkAttackDownSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX;
        private int posY;
        private int width;
        private int height;
        private int delay;
        private int totaldelay=25;

        public LinkAttackDownSprite(Texture2D texture)
        {
            Texture = texture;
       

        }
        public LinkAttackDownSprite()
        {
            //do nothing


        }
        public void Update()
        {
            delay++;
            posX = 0;
            posY = 0;
            width = 15;
            height = 16;
            if (delay > totaldelay / 5 && delay < 2 * totaldelay / 5)
            {
                posX = 1;
                posY = 30;
                width = 13;
                height = 16;

            }
            if (delay >= 2 * totaldelay / 5 && delay < 3 * totaldelay / 5)
            {

                posX = 0;
                posY = 60;
                width = 16;
                height = 15;
            }

            if (delay >= 3 * totaldelay / 6 && delay < 5 * totaldelay / 5)
            {

                posX = 0;
                posY = 84;
                width = 16;
                height = 27;
            }




        }

        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(posX, posY, width, height);     // determine which frame
                Rectangle destinationRectangle = new Rectangle((int)vector.X, (int)vector.Y, width * 3, height * 3);    // determine location and demension of the current frame

                spriteBatch.Begin();
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                spriteBatch.End();
            }
        }

    }
} 
