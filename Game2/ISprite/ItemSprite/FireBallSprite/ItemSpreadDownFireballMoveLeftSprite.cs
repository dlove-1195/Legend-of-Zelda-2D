using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class ItemSpreadDownFireballMoveLeftSprite : ISprite
    {
        public Texture2D Texture;
        private int sourceLocX = 334;
        private int sourceLocY = 3;
        private int width = 8;
        private int height = 10;
        private IItem fire;


        public ItemSpreadDownFireballMoveLeftSprite(Texture2D texture, IItem fire)
        {
            Texture = texture;
            this.fire = fire;
        }

      
        public void Update()
        {
            fire.PosX-=3;
            fire.PosY += 1;
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
                Rectangle destinationRectangle = new Rectangle(fire.PosX, fire.PosY, width * 3, height * 3);
               // spriteBatch.Begin();

                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                //spriteBatch.End();
            }
        }


    }
}
