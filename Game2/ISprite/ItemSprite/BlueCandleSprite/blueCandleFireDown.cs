﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
 

namespace Sprint2
{
    public class blueCandleFireDown:ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX = 300;
        private int posY = 0;
        private int width = 16;
        private int height = 16;
        private IItem candleFire;
        private int timer = 0;
        public blueCandleFireDown(Texture2D texture, IItem candleFire)
        {
            Texture = texture;
            this.candleFire = candleFire;
        }

        public void Update()
        {
            
            timer++;
            if (timer <= 20)
            {
                candleFire.PosY += 7;
            }
            else
            {
                if (timer % 5 == 0)
                {
                    posX = 300;
                    posY = 0;
                }
                else
                {
                    posX = 300;
                    posY = 30;
                }
            }


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
                Rectangle destinationRectangle = new Rectangle(candleFire.PosX, candleFire.PosY, width * 3, height * 3);    // determine location and demension of the current frame

                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

            }
        }

    }
}
