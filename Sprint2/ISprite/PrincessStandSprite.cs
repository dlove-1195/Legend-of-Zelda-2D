using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class PrincessStandSprite : ISprite
    {
        public Texture2D Texture;
        private int width = 14;
        private int height = 26;

        private int sourceLocX=121;
        private int sourceLocY=5;



        public PrincessStandSprite(Texture2D texture)
        {
            Texture = texture;
        }
        public PrincessStandSprite()
        {
            //do nothing
        }

        public void Update()
        {
           //do nothing

        }



        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
                Rectangle destinationRectangle = new Rectangle((int)vector.X, (int)vector.Y, width * 3, height * 3);

                spriteBatch.Begin();
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                spriteBatch.End();
            }
        }
    }
}