using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class WallMaterRightCloseSprite : ISprite
    {
        public Texture2D Texture;
        private int width;
        private int height;
        private int sourceLocX;
        private int sourceLocY;
        int delay = 0;
        int totalDelay =30;

        public WallMaterRightCloseSprite(Texture2D texture)
        {
            Texture = texture;
        }


        public WallMaterRightCloseSprite()
        {
            //another constructor, show nothing
        }
        public void Update()
        {

            width = 14;
            height = 15;
            sourceLocX = 271;
            sourceLocY = 0;
            delay++;
            if (delay >= 5) {
                width = 16;
                height = 16;
                sourceLocX = 270;
                sourceLocY = 30;
            }
            if (totalDelay == delay) {

                delay = 0 ;
                    }

        }



        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
             //   Rectangle destinationRectangle = new Rectangle(WallMaster.posX + delay*3, WallMaster.posY, width * 3, height * 3);

               
             //   spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
               
            }
        }
    }
}