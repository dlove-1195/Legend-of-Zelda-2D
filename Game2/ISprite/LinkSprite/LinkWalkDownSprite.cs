using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkWalkDownSprite : ISprite
    {
        private Texture2D Texture;
        private int width = 15;
        private int height = 16;
        private int sourceLocX = 0;
        private int sourceLocY = 0;

        private int delay = 0;
        private int totalDelay = 10;


      

        public LinkWalkDownSprite(Texture2D texture)
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


          
                Link.posY+=2;
             

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (spriteBatch == null)
            {
                throw new System.ArgumentNullException(nameof(spriteBatch));
            }
            Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
            Rectangle destinationRectangle = new Rectangle(Link.posX,Link.posY , width*3 , height*3 );
             
             
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
           
        }
    }
}
