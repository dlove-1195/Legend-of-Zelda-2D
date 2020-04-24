using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class WoodSwordSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX;
        private int posY;
        private int width;
        private int height;
        private IItem sword;
        private string direction;

        public WoodSwordSprite(Texture2D texture, IItem sword, string d)
        {
            Texture = texture;
            this.sword = sword;
            this.direction = d;
            if (direction.Equals("Down"))
            {
                posX = 4;
                posY = 195;
                width = 7;
                height = 16;
            }
            else if (direction.Equals("Up"))
            {
                posX = 64;
                posY = 195;
                width = 7;
                height = 16;
            }
            else if (direction.Equals("Right"))
            {
                posX = 90;
                posY = 199;
                width = 16;
                height = 7;
            }
            else if (direction.Equals("Left"))
            {
                posX = 30;
                posY = 199;
                width = 16;
                height = 7;
            }
        }

        public void Update()
        {
            if (direction.Equals("Down"))
            {
                sword.PosY += 7;
            }
            else if (direction.Equals("Up"))
            {
                sword.PosY -= 7;
            }
            else if (direction.Equals("Right"))
            {
                sword.PosX += 7;
            }
            else if (direction.Equals("Left"))
            {
                sword.PosX -= 7;
            }



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
                Rectangle destinationRectangle = new Rectangle(sword.PosX, sword.PosY, width * 3, height * 3);    // determine location and demension of the current frame

                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

            }
        }

    }
}
