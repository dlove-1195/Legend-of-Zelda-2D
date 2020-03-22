using Microsoft.Xna.Framework;
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
                
        
            }
        }



        public void switchUnderground(Vector2 destRoomPos, string direction)
        {
            Camera.sourceLocX = (int)destRoomPos.X;
            Camera.sourceLocY = (int)destRoomPos.Y;
            int roomNum = getNextRoomNum(direction);
            room = new Room("room" + roomNum + ".xml");
            Link.posX = 400;
            Link.posY = 300;
            if (roomNum == 15)
            {
                Camera.width = 257;
                Camera.height = 160;
            }
            else
            {
                Camera.width = 257;
                Camera.height = 178;
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
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                    Console.WriteLine("error: no such situation");
#pragma warning restore CA1303 // Do not pass literals as localized parameters
                    break;
            }
            return num;
        }

        private void setLinkPosInNewRoom(string diretion)
        {
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
        public void Update()
        {
           if(load && !Camera.switchRoom)
            {
                load = false;
                room = new Room("room" + roomNum + ".xml");
                setLinkPosInNewRoom(direction);
                
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
