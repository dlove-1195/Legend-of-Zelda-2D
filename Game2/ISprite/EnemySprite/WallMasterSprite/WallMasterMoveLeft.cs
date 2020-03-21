using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class WallMaterMoveLeftSprite : ISprite
    {
        public Texture2D Texture;
        private int width;
        private int height;
        private int sourceLocX;
        private int sourceLocY;

        private int delay = 0;
        private int totalDelay = 30;
        private IEnemy WallMaster;

        public WallMaterMoveLeftSprite(Texture2D texture, IEnemy WallMaster)
        {
            Texture = texture;
            this.WallMaster = WallMaster;
        }


        
        public void Update()
        {

            width = 14;
            height = 15;
            sourceLocX = 241;
            sourceLocY = 0;

            delay++;
                if (delay > 5) {
                width = 16;
                height = 16;
                sourceLocX = 240;
                sourceLocY = 30;
            }   
            if (delay == totalDelay) {
                delay = 0;
            }

        }



        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
               Rectangle destinationRectangle = new Rectangle(WallMaster.posX + delay*-3, WallMaster.posY, width * 3, height * 3);

                
           spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
               
            }
        }
    }
}