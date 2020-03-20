using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Xml;

namespace Sprint2
{

    public class Room : IRoom
    {
        XmlDocument doc;
        XmlNodeList nodeList;
        private String type;
        private String name;
        private int x;
        private int y;
        private int boxWidth;
        private int boxHeight;
        private Vector2 vector;
        public Vector2 roomPos { get; set; }
        public int leftRoomNum { get; set; } = 0;
        public int rightRoomNum { get; set; } = 0;
        public int upRoomNum { get; set; } = 0;
        public int downRoomNum { get; set; } = 0;
        public List<IEnemy> enemies { get; set; }
        public List<Iitem> pickUpItems { get; set; }
        public List<Inpc> npcs { get; set; }
        public List<KeyValuePair<int,int>> stairLocation { get; set; }
        public List<KeyValuePair<int, int>> blockLocation { get; set; }
        public List<KeyValuePair<int,int>> doorLocation { get; set; }
        public List<Rectangle> boundingBox { get; set; }


        public Room(String fileName)
        {
            int windowWidth = Game1.WindowWidth;
            int windowHeight = Game1.WindowHeight;
            enemies = new List<IEnemy>();
            pickUpItems = new List<Iitem>();
            blockLocation = new List<KeyValuePair<int, int>>();
            doorLocation = new List<KeyValuePair<int, int>>();
            stairLocation = new List<KeyValuePair<int, int>>();
            boundingBox = new List<Rectangle>();
            npcs = new List<Inpc>();
            doc = new XmlDocument();
            doc.Load(fileName);
            nodeList = doc.SelectNodes("//Item");
           
            foreach (XmlNode node in nodeList)
            {
                type = node.ChildNodes[0].InnerText;
                name = node.ChildNodes[1].InnerText;
                x = Int32.Parse(node.ChildNodes[2].InnerText); 
                y = Int32.Parse(node.ChildNodes[3].InnerText);
                
                vector.X =  ((float)(x) / 100) * windowWidth;
                vector.Y =  ((float)(y) / 100) * windowHeight;  


                if (type == "Room")
                {
                    if(name == "Room") {
                        roomPos = new Vector2((int)vector.X, (int)vector.Y);
                    }
                 
                    if(name == "Up")
                    {
                        upRoomNum = x;
                    }
                    
                    if(name == "Down")
                    {
                        downRoomNum = x;
                    }
                    
                    if (name == "Left")
                    {
                        leftRoomNum = x;
                    }
                   
                    if (name == "Right")
                    {
                        rightRoomNum = x;
                    }
                    

                }
                else if (type == "Enemy")
                {
                    if (name == "Dragon")
                    {
                        enemies.Add(new Dragon(vector));
                    }
                    if (name == "WallMaster")
                    {
                        
                        enemies.Add(new WallMaster(vector));
                    }
                    if (name == "Flame")
                    {
                        enemies.Add(new Flame(vector));
                    }
                    if (name == "Trap")
                    {
                        enemies.Add(new Trap(vector));
                    }
                    if (name == "Goriya")
                    {
                        enemies.Add(new Goriya(vector));
                    }
                    if (name == "Keese")
                    {
                        enemies.Add(new Keese(vector));
                    }
                    if (name == "Rope")
                    {
                        enemies.Add(new Rope(vector));
                    }
                    if (name == "Stalfos")
                    {
                        enemies.Add(new Stalfos(vector));
                    }
                    if (name == "Zol")
                    {
                        enemies.Add(new Zol(vector));
                    }
                }
                else if (type == "Item")
                {
                    if (name == "BlueDiamond")
                    {
                        pickUpItems.Add(new BlueDiamond(vector));
                    }
                    if (name == "Clock")
                    {
                        pickUpItems.Add(new Clock(vector));
                    }
                    if (name == "Compass")
                    {
                        pickUpItems.Add(new Compass(vector));
                    }
                    if (name == "Fairy")
                    {
                        pickUpItems.Add(new Fairy(vector));
                    }
                    if (name == "Heart")
                    {
                        pickUpItems.Add(new Heart(vector));
                    }
                    if (name == "HeartContainer")
                    {
                        pickUpItems.Add(new HeartContainer(vector));
                    }
                    if (name == "Key")
                    {
                        pickUpItems.Add(new Key(vector));
                    }
                    if (name == "Map")
                    {
                        pickUpItems.Add(new Map(vector));
                    }
                    if (name == "TriforcePiece")
                    {
                        pickUpItems.Add(new TriforcePiece(vector));
                    }
                }
                else if (type == "NPC")
                {
                    if (name == "Merchant")
                    {

                        npcs.Add(new Merchant(vector));

                    }
                    if (name == "OldMan")
                    {

                        npcs.Add(new OldMan(vector));
                    }
                    if (name == "Princess")
                    {
                        npcs.Add(new Princess(vector));
                    }
                }
                else if (type == "Block")
                {
                    blockLocation.Add(new KeyValuePair<int, int>((int)vector.X, (int)vector.Y));

                }
                else if (type == "Door")
                {
                    doorLocation.Add(new KeyValuePair<int, int>((int)vector.X, (int)vector.Y));
                    
                   
                }
                else if (type == "Stair")
                {
                    stairLocation.Add(new KeyValuePair<int, int>((int)vector.X, (int)vector.Y));

                 
                }
                

                //for bounding box in room15
                else if (type == "Box")
                {
                    int width = Int32.Parse(node.ChildNodes[4].InnerText);
                    int height = Int32.Parse(node.ChildNodes[5].InnerText);
                    boxWidth = width / 100 * windowWidth;
                    boxHeight = height / 100 * windowHeight;

                    boundingBox.Add(new Rectangle((int)vector.X, (int)vector.Y, (int)boxWidth, (int)boxHeight));

                }

            }

        }

        //index here would be for the list, not the actual item code for each item, other wise unable to locate several same items.
        public void setItemToNull(int itemNum)
        {
            pickUpItems[itemNum] = null;
        }
        public void setEnemyToNull(int enemyNum)
        {
            enemies[enemyNum] = null;

        }
        public void Update()
        {

           
            foreach (IEnemy enemy in enemies)
            {
                if (enemy != null)
                    enemy.Update();

            }
            foreach (Iitem item in pickUpItems)
            {
                if (item != null)
                    item.Update();

            }
            foreach (Inpc npc in npcs)
            {
                npc.Update();
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {

             
            foreach (IEnemy enemy in enemies)
            {
                if(enemy!=null)
                    enemy.Draw(spriteBatch);
                

            }
            foreach (Iitem item in pickUpItems)
            {
                if (item != null)
                    item.Draw(spriteBatch);

            }
            foreach (Inpc npc in npcs)
            {
                npc.Draw(spriteBatch);
            }
        }
    }
}