using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace Sprint2
{
    public class LockedDoor
    {

        public bool Appear { get; set; } = true;
        //Sprite parameter
        private Texture2D texture = Texture2DStorage.GetDoorSpriteSheet();
        private int sourceLocX;
        private int sourceLocY;
        private int width;
        private int height;
        public int desLocX;
        public int desLocY;
        public int desWidth;
        public int desHeight;
        public string Direction { get; set; }


        public LockedDoor(string direction)
        {
            this.Direction = direction;

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (Direction.Equals("Up"))
            {
                sourceLocX = 1217;
                sourceLocY = 459;
                width = 153;
                height = 94;
                desLocX = 351;
                desLocY = 248;
                desWidth = 95;
                desHeight = 63;
            }
            else if (Direction.Equals("Down"))
            {
                sourceLocX = 1398;
                sourceLocY = 451;
                width = 153;
                height = 94;
                desLocX = 351;
                desLocY = 690;
                desWidth = 95;
                desHeight = 63;
            }
            else if (Direction.Equals("Left"))
            {
                sourceLocX = 1692;
                sourceLocY = 396;
                width = 87;
                height = 154;
                desLocX = 42;
                desLocY = 449;
                desWidth = 57;
                desHeight = 105;
            }
            else if (Direction.Equals("Right"))
            {
                sourceLocX = 1573;
                sourceLocY = 396;
                width = 87;
                height = 154;
                desLocX = 696;
                desLocY = 449;
                desWidth = 57;
                desHeight = 105;
            }
            Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
            Rectangle destinationRectangle = new Rectangle(desLocX, desLocY, desWidth, desHeight);
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
