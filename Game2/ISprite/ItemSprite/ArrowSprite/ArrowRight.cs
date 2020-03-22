using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ArrowRight : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX = 0;
        private int posY = 45;
        private int width = 16;
        private int height = 5;
        private Iitem arrow;

        public ArrowRight(Texture2D texture, Iitem arrow)
        {
            Texture = texture;
            this.arrow = arrow;

        }
        


        public void Update()
        {
            arrow.posX+=4;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(posX, posY, width, height);
                Rectangle destinationRectangle = new Rectangle( arrow.posX,arrow.posY, width * 3, height * 3);    // determine location and demension of the current frame

               
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
               
            }
        }

    }
}