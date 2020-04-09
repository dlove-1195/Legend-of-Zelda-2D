﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkWinningSprite : ISprite
    {
        private Texture2D Texture;
        private int sourceLocX = 31;
        private int sourceLocY = 150;
        private int width = 14;
        private int height = 16;

        public LinkWinningSprite(Texture2D texture)
        {
            Texture = texture;
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