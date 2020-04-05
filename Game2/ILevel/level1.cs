using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class Level1: ILevel
    {
       
        public IRoom room { get; set; }
        private ICamera camera;
        private bool load = false;
         private int roomNum=0; 
        private String direction;
        private List<IRoom> existingRooms = new List<IRoom>();
        //new add
        private bool visit = false;
        private int index = 0;
        public Level1()
        {
            room = new Room("room1.xml");
            existingRooms.Add(room);
            camera = new Camera
            {
                direction = ""
            };
             
        }

        //switch room and camera 
        public void switchRoom(string direction)
        { 
            int roomNum= getNextRoomNum(direction);
            if (roomNum != 0)
            {
                camera.direction = direction;
                Camera.SwitchRoom = true;
                load = true;
                room = new Room();
                Link.posX = 3000;
                Link.posY = 3000; //cannot be seen when room switching 
            }
            this.direction = direction;
            this.roomNum = roomNum;
            //add
            for (int i = 0; i < existingRooms.Count; i++)
            {
                if(existingRooms[i].roomNumber == roomNum)
                {
                    visit = true;
                    index = i;
                }
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

        private void SetLinkPosInNewRoom(String direction)
        {
            switch (direction)
            {
                case "Up":
                    Link.posX = (int)(room.roomPos.X + Game1.WindowWidth * (0.30));
                    Link.posY = (int)(room.roomPos.Y + 600* (0.5));
                    break;

                case "Down":
                    Link.posX = (int)(room.roomPos.X + Game1.WindowWidth * (0.30));
                    Link.posY = (int)(room.roomPos.Y);
                    break;

                case "Left":
                    Link.posX = (int)(room.roomPos.X + Game1.WindowWidth * (0.6));
                    Link.posY = (int)(room.roomPos.Y +600* (0.24));
                    break;

                case "Right":
                    Link.posX = (int)(room.roomPos.X);
                    Link.posY = (int)(room.roomPos.Y +  600 * (0.24));
                    break;

            }

        }
        public void Update()
        {
            if (load && !Camera.SwitchRoom  )
            {
                if (visit)
                {
                    //already exist, no need to create a new room 
                    load = false;
                    room = existingRooms[index];
                    SetLinkPosInNewRoom(direction);
                    visit = false;
                }
                else  
                {
                    load = false;
                    room = new Room("room" + roomNum + ".xml");
                    SetLinkPosInNewRoom(direction);
                    existingRooms.Add(room);

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
