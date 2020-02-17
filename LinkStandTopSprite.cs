using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprite2
{
    public class LinkStandTopSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        private int sourceLocX = 209;
        private int sourceLocY = 122;

        private int width = 16;
        private int height = 32;

        public LinkStandTopSprite(Texture2D texture)
        {
            Texture = texture;
        }


        public void Update()
        {
            //no code 
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            // non-moving, non-animated: source and destination stay the same 
            Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);
            spriteBatch.Begin();

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
s