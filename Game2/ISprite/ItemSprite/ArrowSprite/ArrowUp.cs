 
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ArrowUp : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX = 45;
        private int posY = 40;
        private int width = 5;
        private int height = 16;
        private int currentPos;
        private int gap = 9;


        public ArrowUp(Texture2D texture)
        {
            Texture = texture;
            currentPos = 0;
        }
        public ArrowUp()
        {
            //do nothing
        }
        public void Update()
        {
            currentPos -= 7;



        }

        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(posX, posY, width, height);
                Rectangle destinationRectangle = new Rectangle((int)vector.X + gap, (int)vector.Y + currentPos, width * 3, height * 3);    // determine location and demension of the current frame

                
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
               
            }
        }

    }
}