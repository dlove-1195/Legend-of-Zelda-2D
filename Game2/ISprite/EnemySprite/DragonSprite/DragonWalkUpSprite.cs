﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
 
namespace Sprint2
{ 
    public class DragonWalkUpSprite : ISprite
    {
        public Texture2D Texture;
        private int width;
        private int height;
        private int sourceLocX;
        private int sourceLocY;

        private int delay = 0;
        private int totalDelay = 20;
        

        private bool movingUp= true;

        public DragonWalkUpSprite(Texture2D texture)
        {
            Texture = texture;
        }
        public DragonWalkUpSprite()
        {
            //another constructor do nothing
        }

        public void Update()
        {
            width = 15;
            height = 16;
            sourceLocX = 61;
            sourceLocY = 91;
            if (delay > totalDelay / 4 && delay < 2 * totalDelay / 4)
            {
                sourceLocY = 121;
              
            }
            if (delay >= 2 * totalDelay / 4 && delay < totalDelay)
            {
                sourceLocY = 151;
                width = 16;
            }

            delay++;
            if (delay == totalDelay)
            {
                delay = 0;
            }


            if (movingUp)
            {
                Dragon.posY--;
                if (Dragon.posY <= 0)
                    movingUp = false;
            }
            else
            {
                //doNothing
            }

        }



        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
                Rectangle destinationRectangle = new Rectangle(Dragon.posX, Dragon.posY, width * 3, height * 3);

               
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                
            }
        }
    }
}