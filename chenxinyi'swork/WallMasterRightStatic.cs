using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class WallMasterRightStatic : ISprite
    {
        public Texture2D Texture;
        private int width;
        private int height;
        private int sourceLocX;
        private int sourceLocY;

        public WallMasterRightStatic(Texture2D texture)
        {
            Texture = texture;
        }


        public WallMasterRightStatic()
        {
            //another constructor, show nothing
        }
        public void Update()
        {

            width = 14;
            height = 15;
            sourceLocX = 271;
            sourceLocY = 0;

        }



        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
                Rectangle destinationRectangle = new Rectangle(WallMaster.posX, WallMaster.posY, width * 3, height * 3);

                spriteBatch.Begin();
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                spriteBatch.End();
            }
        }
    }
}