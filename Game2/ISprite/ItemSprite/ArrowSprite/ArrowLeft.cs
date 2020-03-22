using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ArrowLeft : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX = 40;
        private int posY = 5;
        private int width = 16;
        private int height = 5;
        private IItem arrow;

        public ArrowLeft(Texture2D texture, IItem arrow)
        {
            Texture = texture;
            this.arrow = arrow;

        }
        

        public void Update()
        {
            arrow.PosX-=4;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(posX, posY, width, height);
                Rectangle destinationRectangle = new Rectangle(arrow.PosX, arrow.PosY, width * 3, height * 3);    // determine location and demension of the current frame

               
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                
            }
        }

    }
}