using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class WoodenSwordRight : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX = 90;
        private int posY = 199;
        private int width = 16;
        private int height = 7;
        private IItem sword;
        public WoodenSwordRight(Texture2D texture, IItem sword)
        {
            Texture = texture;
            this.sword = sword;
        }

        public void Update()
        {
            sword.PosX+=7;
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
                Rectangle destinationRectangle = new Rectangle( sword.PosX, sword.PosY, width * 3, height * 3);    // determine location and demension of the current frame

                
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
              
            }
        }

    }
}
