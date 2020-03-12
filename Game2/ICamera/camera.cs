using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class camera : ICamera
    {
        public Texture2D Texture = Texture2DStorage.GetDungeonSpriteSheet();
        private string direction;
        private int width = 257;
        private int height = 176;
        private int sourceLocX = 514;
        private int sourceLocY = 355;


        public camera(string direction)
        {
            this.direction = direction;
        }

        public void Update()
        {
            if (direction.Equals(""))
            {
                // do nothing
            }
            else if (direction.Equals("up"))
            {
                if (sourceLocY > 355 - 176)
                {
                    sourceLocY--;
                }
            }
            else if (direction.Equals("down"))
            {
                if (sourceLocY > 355 - 176)
                {
                    sourceLocY++;
                }
            }
            else if (direction.Equals("left"))
            {
                if (sourceLocY > 355 - 176)
                {
                    sourceLocX--;
                }
            }
            else if (direction.Equals("right"))
            {
                if (sourceLocY > 355 - 176)
                {
                    sourceLocX++;
                }
            }

        }


        public void Draw(SpriteBatch spriteBatch)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
                Rectangle destinationRectangle = new Rectangle(0, 0, Game1.WindowWidth, Game1.WindowHeight);

                spriteBatch.Begin();
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                spriteBatch.End();
            }
        }
    }
}