using Microsoft.Xna.Framework.Input;
namespace Sprint2
{
    public class CameraController : IController
    {
        private int roomNum = 0;

        //private ICamera camera;
        //private string direction = "";
        public Game1 Game { get; set; }
        public CameraController(Game1 game)
        {
            Game = game;
        }
        public void Update()
        {
            MouseState mouse = Mouse.GetState();
            if (mouse.LeftButton == ButtonState.Pressed && mouse.Y < 20) //up room
            {
                if (roomNum == 0)
                {
                    Game.background = new camera("up");
                    roomNum = 2;
                }
            }
            else if (mouse.LeftButton == ButtonState.Pressed && mouse.Y > Game1.WindowHeight - 20) //down room
            {
                if (roomNum == 0)
                {
                    Game.background = new camera("down");
                    roomNum = 3;
                }
            }
            if (mouse.LeftButton == ButtonState.Pressed && mouse.X < 20) //left room
            {
                if (roomNum == 0)
                {
                    Game.background = new camera("left");
                    roomNum = 4;
                }
            }
            if (mouse.LeftButton == ButtonState.Pressed && mouse.X < Game1.WindowWidth-20) //right room
            {
                if (roomNum == 0)
                {
                    Game.background = new camera("right");
                    roomNum = 5;
                }
            }

        }
    }
}
