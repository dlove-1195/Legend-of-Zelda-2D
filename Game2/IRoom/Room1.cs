using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Xml;

namespace Sprint2
{
    
    public class Room1 : IRoom
    {
        XmlDocument doc;
        XmlNodeList nodeList;
        private String type;
        private String name; 
        private int posX;
        private int posY;
        
        public Vector2 roomSize { get; set; }
        public List<KeyValuePair<Iplayer,Vector2>> player { get; set; }
        public List<KeyValuePair<IEnemy,Vector2>> enemies { get; set; }
        public List<KeyValuePair<Iitem, Vector2>> pickUpItems{ get;set;}
        public List<KeyValuePair<Inpc, Vector2>> npcs { get; set; }

        public Room1()
        {
            enemies = new List<KeyValuePair<IEnemy, Vector2>>();
            pickUpItems = new List<KeyValuePair<Iitem, Vector2>>();
            npcs = new List<KeyValuePair<Inpc, Vector2>>();
            doc = new XmlDocument();
            doc.Load("room1.xml");

            nodeList = doc.GetElementsByTagName("Item");
            foreach (XmlNode node in nodeList){
                type = node.ChildNodes[0].InnerText;
                name = node.ChildNodes[1].InnerText;
                posX = Int32.Parse(node.ChildNodes[2].InnerText);
                posY = Int32.Parse(node.ChildNodes[3].InnerText);

                if (type == "Room")
                {
                    roomSize = new Vector2(posX, posY);

                }
                else if (type == "Player")
                {
                    player.Add(new KeyValuePair<Iplayer, Vector2>(new Link(), new Vector2(posX, posY)));
                    
                    
                } 
                else if (type == "Enemy")
                {
                    if(name == "Dragon")
                    {
                        enemies.Add(new KeyValuePair<IEnemy, Vector2>(new Dragon(), new Vector2(posX, posY)));
                    }
                    if (name == "WallMaster")
                    {
                        enemies.Add(new KeyValuePair<IEnemy, Vector2>(new WallMaster(), new Vector2(posX, posY)));
                    }
                    if (name == "Flame")
                    {
                        enemies.Add(new KeyValuePair<IEnemy, Vector2>(new Flame(), new Vector2(posX, posY)));
                    }
                    if (name == "Trap")
                    {
                        enemies.Add(new KeyValuePair<IEnemy, Vector2>(new Trap(), new Vector2(posX, posY)));
                    }
                    if (name == "Goriya")
                    {
                        enemies.Add(new KeyValuePair<IEnemy, Vector2>(new Goriya(), new Vector2(posX, posY)));
                    }
                    if (name == "Keese")
                    {
                        enemies.Add(new KeyValuePair<IEnemy, Vector2>(new Keese(), new Vector2(posX, posY)));
                    }
                    if (name == "Rope")
                    {
                        enemies.Add(new KeyValuePair<IEnemy, Vector2>(new Rope(), new Vector2(posX, posY)));
                    }
                    if (name == "Stalfos")
                    {
                        enemies.Add(new KeyValuePair<IEnemy, Vector2>(new Stalfos(), new Vector2(posX, posY)));
                    }
                    if (name == "Zol")
                    {
                        enemies.Add(new KeyValuePair<IEnemy, Vector2>(new Zol(), new Vector2(posX, posY)));
                    }
                }
                else if (type == "Item")
                {
                    if (name == "BlueDiamond")
                    {
                        pickUpItems.Add(new KeyValuePair<Iitem, Vector2>(new BlueDiamond(), new Vector2(posX, posY)));
                    }
                    if (name == "Clock")
                    {
                        pickUpItems.Add(new KeyValuePair<Iitem, Vector2>(new Clock(), new Vector2(posX, posY)));
                    }
                    if (name == "Compass")
                    {
                        pickUpItems.Add(new KeyValuePair<Iitem, Vector2>(new Compass(), new Vector2(posX, posY)));
                    }
                    if (name == "Fairy")
                    {
                        pickUpItems.Add(new KeyValuePair<Iitem, Vector2>(new Fairy(), new Vector2(posX, posY)));
                    }
                    if (name == "Heart")
                    {
                        pickUpItems.Add(new KeyValuePair<Iitem, Vector2>(new Heart(), new Vector2(posX, posY)));
                    }
                    if (name == "HeartContainer")
                    {
                        pickUpItems.Add(new KeyValuePair<Iitem, Vector2>(new HeartContainer(), new Vector2(posX, posY)));
                    }
                    if (name == "Key")
                    {
                        pickUpItems.Add(new KeyValuePair<Iitem, Vector2>(new Key(), new Vector2(posX, posY)));
                    }
                    if (name == "Map")
                    {
                        pickUpItems.Add(new KeyValuePair<Iitem, Vector2>(new Map(), new Vector2(posX, posY)));
                    }
                    if (name == "TriforcePiece")
                    {
                        pickUpItems.Add(new KeyValuePair<Iitem, Vector2>(new TriforcePiece(), new Vector2(posX, posY)));
                    }
                }
                else if (type == "NPC")
                {
                    if (name == "Merchant")
                    {

                        npcs.Add(new KeyValuePair<Inpc, Vector2>(new Merchant(), new Vector2(posX, posY)));
                      
                    }
                    if (name == "OldMan")
                    {

                        npcs.Add(new KeyValuePair<Inpc, Vector2>(new OldMan(), new Vector2(posX, posY)));
                    }
                    if (name == "Princess")
                    {
                        npcs.Add(new KeyValuePair<Inpc, Vector2>(new Princess(), new Vector2(posX, posY)));
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

            foreach (KeyValuePair<Iplayer, Vector2> pair in player)
            {
                pair.Key.Draw(spriteBatch, pair.Value);

            }

            foreach (KeyValuePair < IEnemy,Vector2 > pair in enemies)
            {
                pair.Key.Draw(spriteBatch, pair.Value);
               
            }
            foreach (KeyValuePair<Iitem, Vector2> pair in pickUpItems)
            {
                pair.Key.Draw(spriteBatch, pair.Value);

            }
            foreach (KeyValuePair<Inpc, Vector2> pair in npcs)
            {
                pair.Key.Draw(spriteBatch, pair.Value);
            }
        }
    }
}
