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
        private String location;

        public Iplayer player { get; set; }
        public List<IEnemy> enemies { get; set; }
        public List<Iitem> pickUpItems{ get;set;}
        public List<Inpc> npcs { get; set; }

        public Room1()
        {
            enemies = new List<IEnemy>();
            pickUpItems = new List<Iitem>();
            npcs = new List<Inpc>();
            doc = new XmlDocument();
            doc.Load("room1.xml");

            nodeList = doc.GetElementsByTagName("Item");
            foreach (XmlNode node in nodeList){
                type = node.ChildNodes[0].InnerText;
                name = node.ChildNodes[1].InnerText;
                location = node.ChildNodes[2].InnerText;

                if(type == "Player")
                {
                    player = new Link();
                } else if (type == "Enemy")
                {
                    if(name == "Dragon")
                    {
                        enemies.Add(new Dragon());
                    }
                    if(name == "WallMaster")
                    {
                        enemies.Add(new WallMaster());
                    }
                }else if (type == "Item")
                {
                    if(name == "Clock")
                    {
                        pickUpItems.Add(new Clock());
                    }
                    if (name == "Heart")
                    {
                        pickUpItems.Add(new Heart());
                    }
                }
                else if (type == "NPC")
                {
                    if (name == "Merchant")
                    {
                        npcs.Add(new Merchant());
                    }
                    if (name == "OldMan")
                    {
                        npcs.Add(new OldMan());
                    }
                    if (name == "Princess")
                    {
                        npcs.Add(new Princess());
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
            spriteBatch.Begin();
            player.Draw(spriteBatch);
            foreach (IEnemy enemy in enemies){
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
            spriteBatch.End();
        
    }
    }
}
