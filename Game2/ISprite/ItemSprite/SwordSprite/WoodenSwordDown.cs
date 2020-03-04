using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class WoodenSwordDown : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX = 4;
        private int posY = 195;
        private int width = 7;
        private int height = 16;
        private int currentPos;
        private int gap = 13;


        public WoodenSwordDown(Texture2D texture)
        {
            Texture = texture;
            currentPos = 0;
        }
        public WoodenSwordDown()
        {
            //do nothing
        }

        public void Update()
        {
            currentPos += 7;
            

            
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            if(Texture != null){
                Rectangle sourceRectangle = new Rectangle(posX, posY, width, height);     
                Rectangle destinationRectangle = new Rectangle((int)vector.X +gap , (int)vector.Y + currentPos, width * 3, height * 3);    // determine location and demension of the current frame
                 
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                
            }
        }

    }
}
