using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class WoodenSwordLeft : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX = 30;
        private int posY = 199;
        private int width = 16;
        private int height = 7;
        private Iitem sword;
        public WoodenSwordLeft(Texture2D texture, Iitem sword)
        {
            Texture = texture;
            this.sword = sword;
        }
        

        public void Update()
        {
            sword.posX-=7;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(posX, posY, width, height);
                Rectangle destinationRectangle = new Rectangle( sword.posX,sword.posY, width * 3, height * 3);    // determine location and demension of the current frame

                 
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                 
            }
        }

    }
}
