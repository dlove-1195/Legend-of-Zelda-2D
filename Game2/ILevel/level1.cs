using Microsoft.Xna.Framework.Graphics;
using System;

namespace Sprint2
{
    public class Level1: ILevel
    {
       
        public IRoom room { get; set; }
        private ICamera camera;
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
            if (roomNum != 0)
            {
                camera.direction = direction;
                Camera.switchRoom = true;
                room = new Room("room" + roomNum + ".xml");
                //change link's position using door location
                //need to know its current enter door and position 
                Link.posX = (int)room.doorLocation[0].Value.X;
                Link.posX = (int)room.doorLocation[0].Value.Y;


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
