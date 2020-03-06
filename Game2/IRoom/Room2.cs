using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Xml;

namespace Sprint2
{
    class Room2 :IRoom
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

        public List<Iplayer> player { get; set; }
        public List<IEnemy> enemies { get; set; }
        public List<Iitem> pickUpItems { get; set; }
        public List<Inpc> npcs { get; set; }
        public List<KeyValuePair<int, int>> blockLocation { get; set; }

        public Room2()
        {
        
            doc = new XmlDocument();
            enemies = new List<IEnemy>();
            pickUpItems = new List<Iitem>();
            npcs = new List<Inpc>();
            doc.Load("Room2.xml");

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
                else if (type == "NPC")
                {
                    if (name == "OldMan")
                    {

                        npcs.Add(new OldMan(vector));
                    }
                }
                else if (type == "Enemy")
                {
                    if (name == "Flame")
                    {
                        enemies.Add(new Flame(vector));
                    }
                }

        public void Update() { 
            //
        }

        public void Draw(SpriteBatch spriteBatch) {
            player.Draw(spriteBatch);
            foreach (IEnemy enemy in enemies)
            {
                enemy.Draw(spriteBatch);
            }
            foreach (Inpc npc in npcs)
            {
                npc.Draw(spriteBatch);
            }

        }
    }
}
