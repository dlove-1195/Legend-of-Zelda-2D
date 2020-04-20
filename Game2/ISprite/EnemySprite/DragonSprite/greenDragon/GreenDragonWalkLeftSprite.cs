﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
   
    public class GreenDragonWalkLeftSprite : ISprite
    {
        private Texture2D Texture;
        private int width ;
        private int height ;
        private int sourceLocX;
        private int sourceLocY ;

        private int delay = 0;
        private int totalDelay = 20;
       
        private IEnemy GreenDragon;

        public GreenDragonWalkLeftSprite(Texture2D texture, IEnemy dragon)
        {
            Texture = texture;
            GreenDragon = dragon;
        }
       
        public void Update() {
            if (Level1.roomUpdate)
            {
                width = 24;
            height = 32;

            if (delay == totalDelay)
            {
                delay = 0;

            }

            if (delay <= totalDelay / 4)
            {
                sourceLocX = 4;
                sourceLocY = 0;
            }


            if (delay > totalDelay / 4 && delay < 2 * totalDelay / 4)
            {
                sourceLocX = 49;
                sourceLocY = 0;
            }
            if (delay >= 2 * totalDelay / 4 && delay < 3* totalDelay/4)
            {
                sourceLocX = 94;
                sourceLocY = 0;
            }
            if (delay >= 3 * totalDelay / 4 && delay <= totalDelay)
            {
                sourceLocX = 139;
                sourceLocY = 0;
            }

            delay++;
          
                GreenDragon.posX--;
            }
            

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
                Rectangle destinationRectangle = new Rectangle(GreenDragon.posX, GreenDragon.posY, width * 3, height * 3);

                
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                 
            }
        }
    }
}
