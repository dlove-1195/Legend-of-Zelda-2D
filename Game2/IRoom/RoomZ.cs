using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Xml;

namespace Sprint2
{

    public class RoomZ : IRoom
    {
        XmlDocument doc;
        XmlNodeList nodeList;
        private String type;
        private String name;
        private int posX;
        private int posY;
        private Vector2 vector;
        ICamera camera;
        public Vector2 roomSize { get; set; }

        public Iplayer player { get; set; }
        public List<IEnemy> enemies { get; set; }
        public List<Iitem> pickUpItems { get; set; }
        public List<Inpc> npcs { get; set; }

        public RoomZ()
        {
            enemies = new List<IEnemy>();
            pickUpItems = new List<Iitem>();
            npcs = new List<Inpc>();
            doc = new XmlDocument();
            doc.Load("roomZ.xml");

            nodeList = doc.GetElementsByTagName("Item");
            foreach (XmlNode node in nodeList)
            {
                type = node.ChildNodes[0].InnerText;
                name = node.ChildNodes[1].InnerText;
                posX = Int32.Parse(node.ChildNodes[2].InnerText);
                posY = Int32.Parse(node.ChildNodes[3].InnerText);
                vector.X = camera.posX + posX;
                vector.Y = camera.posX + posY;

                if (type == "Room")
                {
                    roomSize = new Vector2(posX, posY);

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
            }
        }

        public void Update()
        {
            //do nothing
        }
        public void Draw(SpriteBatch spriteBatch)
        {

            player.Draw(spriteBatch);

            foreach (IEnemy enemy in enemies)
            {
                enemy.Draw(spriteBatch);

            }
            foreach (Iitem item in pickUpItems)
            {
                item.Draw(spriteBatch);

            }
            foreach (Inpc npc in npcs)
            {
                npc.Draw(spriteBatch);
            }
        }
    }