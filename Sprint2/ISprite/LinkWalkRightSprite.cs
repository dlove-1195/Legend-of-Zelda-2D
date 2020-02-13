using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkWalkRightSprite : ISprite
    {
        public Texture2D Texture;
        private int width=14;
        private int height=15;
        private int sourceLocX = 91;
        private int sourceLocY = 0;

        //animated part 

        private int delay = 0;
        private int totalDelay = 10;
        //moving part 
         
        private bool movingRight = true;

        public LinkWalkRightSprite(Texture2D texture)
        {
            Texture = texture;
    }


        public void Update()
        {
            if (delay > totalDelay/2)
            {
      
                width = 15;
                height = 16;
                sourceLocX = 90;
                sourceLocY = 30;
                if( delay == totalDelay)
                {
                    delay = 0;
                }
                
            }
            else
            {
                width = 14;
                height = 15;
                sourceLocX = 91;
                sourceLocY = 0;
            }
            delay++;
       
            //moving left and right 
            if (movingRight)
            {
                Link.posX++;
                if ( Link.posX == 800)
                    movingRight = false;
            }
            else
            {
                 //doNothing
            }


        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
            Rectangle destinationRectangle = new Rectangle(Link.posX,Link.posY , width*3 , height*3 );
             
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
