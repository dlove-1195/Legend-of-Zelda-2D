using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class GreenDragonDamageWalkLeftSprite : ISprite
    {
        private Texture2D Texture;
        private int sourceLocX;
        private int sourceLocY;
        private int width;
        private int height;

        private int delay = 0;
        private int totalDelay = 10;
        private IEnemy GreenDragon;

        public GreenDragonDamageWalkLeftSprite(Texture2D texture, IEnemy dragon)
        {
            Texture = texture;
            GreenDragon = dragon;
        }



        public void Update()
        {
            width = 24;
            height = 32;
            if (delay == totalDelay)
            {
                delay = 0;

            }

            if (delay <= totalDelay / 4)
            {
                sourceLocX = 262; 
                sourceLocY = 227;
            }


            if (delay > totalDelay / 4 && delay < 2 * totalDelay / 4)
            {
                sourceLocX = 293;
                sourceLocY = 227;
            }
            if (delay >= 2 * totalDelay / 4 && delay < 3 * totalDelay / 4)
            {
                sourceLocX = 324;
                sourceLocY = 227;
            }
            if (delay >= 3 * totalDelay / 4 && delay <= totalDelay)
            {
                sourceLocX = 355;
                sourceLocY = 227;
            }

            delay++;
            if (Level1.roomUpdate)
            {
                GreenDragon.posX--;
            }

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
            Rectangle destinationRectangle = new Rectangle(GreenDragon.posX, GreenDragon.posY, width * 3, height * 3);

            
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
             
        }
    }
}
