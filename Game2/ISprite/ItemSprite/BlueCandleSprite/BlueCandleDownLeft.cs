﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlueCandleDownLeft : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX = 38;
        private int posY = 11;
        private int width = 8;
        private int height = 16;


        public BlueCandleDownLeft(Texture2D texture)
        {
            Texture = texture;
        }
        public BlueCandleDownLeft()
        {
            //do nothing
        }

        public void Update()
        {
            //do nothing



        }

        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(posX, posY, width, height);
                Rectangle destinationRectangle = new Rectangle((int)vector.X, (int)vector.Y, width * 3, height * 3);    // determine location and demension of the current frame

                 
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                 
            }
        }

    }
}