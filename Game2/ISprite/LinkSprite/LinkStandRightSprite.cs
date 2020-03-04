﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkStandRightSprite : ISprite
    {
        public Texture2D Texture;
        private int sourceLocX = 90;
        private int sourceLocY = 30;
        private int width = 15;
        private int height = 16;

        public LinkStandRightSprite(Texture2D texture)
        {
            Texture = texture;
        }


        public void Update()
        {
            //no code 
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width * 3, height * 3);
            
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
             
        }
    }
}