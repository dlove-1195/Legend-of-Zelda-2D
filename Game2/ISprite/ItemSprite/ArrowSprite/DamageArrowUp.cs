 
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class DamageArrowUp : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX = 154;
        private int posY = 46;
        private int width = 5;
        private int height = 16;
        private IItem arrow;

        public DamageArrowUp(Texture2D texture, IItem arrow)
        {
            Texture = texture;
            this.arrow = arrow;

        }
       
        public void Update()
        {
            arrow.PosY-=4;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            if (spriteBatch == null)
            {
                throw new System.ArgumentNullException(nameof(spriteBatch));
            }
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(posX, posY, width, height);
                Rectangle destinationRectangle = new Rectangle(arrow.PosX,arrow.PosY, width * 3, height * 3);    // determine location and demension of the current frame

                
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
               
            }
        }

    }
}