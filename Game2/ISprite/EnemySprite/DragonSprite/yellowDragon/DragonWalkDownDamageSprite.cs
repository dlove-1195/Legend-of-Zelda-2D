﻿using System; 
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class DragonWalkDownDamageSprite : ISprite
    {
        private Texture2D Texture;
        private int width;
        private int height;
        private int sourceLocX;
        private int sourceLocY;

        private int delay = 0;
        private int totalDelay = 20;
 
        private IEnemy Dragon;

        public DragonWalkDownDamageSprite(Texture2D texture, IEnemy dragon )
        {
            Texture = texture;
            Dragon = dragon;
        }


     
        public void Update()
        {
            
            width = 15;
            height = 16;
            sourceLocX = 1;
            sourceLocY = 91;
            if (delay > totalDelay / 4 && delay < 2*totalDelay /4)
            {
                sourceLocY = 121;
                width = 16;
            }
            if (delay >= 2*totalDelay / 4 && delay < totalDelay)
            {
                sourceLocY = 175;
                width = 16;
            }
            delay++;
            if (delay == totalDelay)
            {
                delay = 0;
            }
             
                Dragon.posY++;
          
        }



        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
                Rectangle destinationRectangle = new Rectangle(Dragon.posX, Dragon.posY, width * 3, height * 3);

                
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                
            }
        }
    }
}