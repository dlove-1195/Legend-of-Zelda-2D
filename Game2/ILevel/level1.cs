using Microsoft.Xna.Framework;
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
            camera = new camera("");
        }

        //switch room and camera 
        public void switchRoom(string direction)
        {
           int roomNum= getNextRoomNum(direction);
            if (roomNum != 0)
            {
                room = new Room("room" + roomNum + ".xml");
                camera = new camera(direction);
            }
        }

        public int getNextRoomNum(string direction)
        {
            int num = 0 ;
            switch (direction)
            {
                case "left":
                    num = room.leftRoomNum;
                    break;
                case "right":
                    num = room.rightRoomNum;
                    break;
                case "up":
                    num = room.upRoomNum;
                    break;
                case "down":
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
            room.Update();
            camera.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            room.Draw(spriteBatch);
            camera.Draw(spriteBatch);
        }
    }
}
