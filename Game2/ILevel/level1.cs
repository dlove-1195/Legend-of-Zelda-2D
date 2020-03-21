using Microsoft.Xna.Framework.Graphics;
using System;

namespace Sprint2
{
    public class Level1: ILevel
    {
       
        public IRoom room { get; set; }
        private ICamera camera;
        private bool load = false;
        private int roomNum;
        private String direction;
        public Level1()
        {
            room = new Room("room1.xml");
            camera = new Camera();
            camera.direction = "";
        }

        //switch room and camera 
        public void switchRoom(string direction)
        {
           int roomNum= getNextRoomNum(direction);
            this.roomNum = roomNum;
            this.direction = direction;
            if (roomNum != 0)
            {
                camera.direction = direction;
                Camera.switchRoom = true;
                load = true;
                room = new Room();
                Link.posX = 3000;
                Link.posY = 3000; //cannot be seen when room switching
                //change link's position using door location
                //need to know its current enter door and position 
        
            }
        }

        public int getNextRoomNum(string direction)
        {
            int num = 0 ;
            switch (direction)
            {
                case "Left":
                    num = room.leftRoomNum;
                    break;
                case "Right":
                    num = room.rightRoomNum;
                    break;
                case "Up":
                    num = room.upRoomNum;
                    break;
                case "Down":
                    num = room.downRoomNum;
                    break;

                default:
                    Console.WriteLine("error: no such situation");
                    break;
            }
            return num;
        }


        public void Update()
        {
           if(load && !Camera.switchRoom)
            {
                load = false;
                room = new Room("room" + roomNum + ".xml");
                switch (direction)
                {
                    case "Up":
                        Link.posX = (int)(room.roomPos.X + Game1.WindowWidth * (0.30));
                        Link.posY = (int)(room.roomPos.Y + Game1.WindowHeight * (0.5));
                        break;

                    case "Down":
                        Link.posX = (int)(room.roomPos.X + Game1.WindowWidth * (0.30));
                        Link.posY = (int)(room.roomPos.Y);
                        break;

                    case "Left":
                        Link.posX = (int)(room.roomPos.X + Game1.WindowWidth * (0.6));
                        Link.posY = (int)(room.roomPos.Y + Game1.WindowHeight * (0.24));
                        break;

                    case "Right":
                        Link.posX = (int)(room.roomPos.X);
                        Link.posY = (int)(room.roomPos.Y + Game1.WindowHeight * (0.24));
                        break;

                }
            }
            camera.Update();

            room.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
          
            camera.Draw(spriteBatch);
            room.Draw(spriteBatch);
        }
    }
}
