using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkWalkLeftSprite : ISprite
    {
        public Texture2D Texture;
        private int width=14;
        private int height=15;
        private int sourceLocX = 31;
        private int sourceLocY = 30;
        //animated part 
    
        private int delay = 0;
        private int totalDelay = 10;
        //moving part 
         
        private bool movingLeft = true;

        public LinkWalkLeftSprite(Texture2D texture)
        {
            Texture = texture;
    }


        public void Update()
        {
            if (delay > totalDelay / 2)
            {

                width = 15;
                height = 16;
                sourceLocX = 30;
                sourceLocY = 0;
                if (delay == totalDelay)
                {
                    delay = 0;
                }
            }
            else
            {
               
                width = 14;
                height = 15;
                sourceLocX = 31;
                sourceLocY = 30;
            }
            delay++;
       
            //moving left and right 
            if (movingLeft)
            {
                Link.posX--;
                if ( Link.posX <= 0)
                    movingLeft = false;
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
