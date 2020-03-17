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
        private Vector2 vector;
        public Vector2 roomSize { get; set; }
        public int leftRoomNum { get; set; }
        public int rightRoomNum { get; set; }
        public int upRoomNum { get; set; }
        public int downRoomNum { get; set; }
        public Iplayer player { get; set; }
        public List<IEnemy> enemies { get; set; }
        public List<Iitem> pickUpItems { get; set; }
        public List<Inpc> npcs { get; set; }
        public List<KeyValuePair<int, int>> blockLocation { get; set; }
        public List<KeyValuePair<int,int>> doorLocation { get; set; }



        public Room(String fileName)
        {
            enemies = new List<IEnemy>();
            pickUpItems = new List<Iitem>();
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
         
                vector.X =  x;
                vector.Y =  y;

                if (type == "Room")
                {
                    roomSize = new Vector2(x, y);
                    if(name == "Up")
                    {
                        upRoomNum = x;
                    }
                    else
                    {
                        upRoomNum = 0;
                    }
                    if(name == "Down")
                    {
                        downRoomNum = x;
                    }
                    else
                    {
                        downRoomNum = 0;
                    }
                    if (name == "Left")
                    {
                        leftRoomNum = x;
                    }
                    else
                    {
                        leftRoomNum = 0;
                    }
                    if (name == "Right")
                    {
                        rightRoomNum = x;
                    }
                    else
                    {
                        rightRoomNum = 0;
                    }

                }
                else if (type == "Player")
                {
                    player = new Link(vector);

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
                    blockLocation.Add(new KeyValuePair<int, int>(x, y));
                }
                else if (type == "Door")
                {
                    doorLocation.Add(new KeyValuePair<int, int>( x, y));
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
            player.Update();

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

            player.Draw(spriteBatch);

            foreach (IEnemy enemy in enemies)
            {
                if (enemy != null)
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