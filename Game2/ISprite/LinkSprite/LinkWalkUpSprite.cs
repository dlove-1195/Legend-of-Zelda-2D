using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkWalkUpSprite : ISprite
    {
        private Texture2D Texture;
        private int width=12;
        private int height=16;
        private int sourceLocX = 62;
        private int sourceLocY = 30;

        private int delay = 0;
        private int totalDelay = 10;
      
         
        

        public LinkWalkUpSprite(Texture2D texture)
        {
            Texture = texture;
    }


        public void Update()
        {
            if (delay > totalDelay / 2)
            {
                sourceLocY = 0;
                if (delay == totalDelay)
                {
                    delay = 0;
                }
            }
            else
            {
                sourceLocY = 30;
            }
            delay++;
           
 
                Link.posY-=2;
             

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
            Rectangle destinationRectangle = new Rectangle(Link.posX,Link.posY , width*3 , height*3);
             
             
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
          
        }
    }
}
