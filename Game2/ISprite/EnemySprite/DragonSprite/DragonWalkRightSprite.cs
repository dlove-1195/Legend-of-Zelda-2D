using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class DragonWalkRightSprite : ISprite
    {
        public Texture2D Texture;
        private int width;
        private int height;
        private int sourceLocX;
        private int sourceLocY;

        private int delay = 0;
        private int totalDelay = 20;
    
        private IEnemy Dragon;

        public DragonWalkRightSprite(Texture2D texture, IEnemy dragon)
        {
            Texture = texture;
            Dragon = dragon;
        }


        public void Update()
        {
            width = 28;
            height = 15;
            sourceLocX = 85;
            sourceLocY = 91;
            if (delay == totalDelay)
            {
                delay = 0;
                
            }
           
            if (delay > totalDelay / 4 && delay < 2 * totalDelay / 4)
            {
                sourceLocY = 121;
                width = 28;
                height = 16;
            }
            if (delay >= 2 * totalDelay / 4 && delay < totalDelay)
            {
                sourceLocX = 83;
                sourceLocY = 151;
                width = 32;
                height = 16;

            }

            delay++;

           
                Dragon.posX++;
                
              

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
