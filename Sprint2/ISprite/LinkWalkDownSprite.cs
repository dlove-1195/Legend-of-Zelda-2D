using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkWalkDownSprite : ISprite
    {
        public Texture2D Texture;
        private int width=16;
        private int height=15;
        
         private int currentFrame = 0;
        private int totalFrames = 3;
        private int delay = 0;
        private int totalDelay = 3;
      
         
        private bool movingDown = true;

        public LinkWalkDownSprite(Texture2D texture)
        {
            Texture = texture;
    }


        public void Update()
        {
            delay++;
            if (delay == totalDelay)
            {
                currentFrame++;
                delay = 0;
            }

            if (currentFrame == totalFrames) { currentFrame = 0; }
           
            if (movingDown)
            {
                Link.posY++;
                if ( Link.posY == 480)
                    movingDown = false;
            }
            else
            {
                 //doNothing
            }


        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {


            int sourceLocX = 0;
            int sourceLocY = currentFrame*30;
            Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
            Rectangle destinationRectangle = new Rectangle(Link.posX,Link.posY , width*3 , height*3 );
             
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
