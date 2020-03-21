using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Camera : ICamera
    {
        public Texture2D Texture = Texture2DStorage.GetDungeonSpriteSheet();
        public string direction { get; set; }
        public bool switchRoom { get; set; }

        //room15 is smaller (257,160)
        //other rooms (257,178)
        private int width = 257;
        private int height = 160;
        private int sourceLocX = 0;
        private int sourceLocY = 0;
        //room1:(515,179) room10:(1,532) room11:(772,353) room12:(1030,530) room13:(0,707) room14:(515,885) room15:(0,0)

        private int delay = 0;


        public Camera()
        {
            direction = "";
            switchRoom = false;
        }

        public void Update()
        {
            if (direction.Equals(""))
            {
                // do nothing
            }
            else if (direction.Equals("up"))
            {
                if (switchRoom)
                {
                    sourceLocY--;
                    delay++;
                    if (delay >= 176)
                    {
                        switchRoom = false;
                    }

                }
                else
                {
                    delay = 0;
                    direction = "";
                }
            }
            else if (direction.Equals("down"))
            {

                if (switchRoom)
                {
                    sourceLocY++;
                    delay++;
                    if (delay >= 176)
                    {
                        switchRoom = false;
                    }

                }
                else
                {
                    delay = 0;
                    direction = "";
                }
            }
            else if (direction.Equals("left"))
            {
                if (switchRoom)
                {
                    sourceLocX--;
                    delay++;
                    if (delay >= 256)
                    {
                        switchRoom = false;
                    }

                }
                else
                {
                    delay = 0;
                    direction = "";
                }
            }
            else if (direction.Equals("right"))
            {
                if (switchRoom)
                {
                    sourceLocX++;
                    delay++;
                    if (delay >= 256)
                    {
                        switchRoom = false;
                    }

                }
                else
                {
                    delay = 0;
                    direction = "";
                }

            }

        }


        public void Draw(SpriteBatch spriteBatch)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
                Rectangle destinationRectangle = new Rectangle(0, 0, Game1.WindowWidth, Game1.WindowHeight);


                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

            }
        }
    }
}