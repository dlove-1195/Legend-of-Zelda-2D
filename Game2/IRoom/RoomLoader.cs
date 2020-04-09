using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Xml;

namespace Sprint2
{

    public class RoomLoader
    {

        public XmlNodeList nodeList { get; set; }
        public XmlDocument doc { get; set; }
        private Room room;

        public RoomLoader(String fileName)
        {
            XmlReader reader;
            XmlReaderSettings settings = new XmlReaderSettings();
            XmlUrlResolver resolver = new XmlUrlResolver();
            reader = XmlReader.Create(fileName, settings);
            doc = new XmlDocument();
            doc.XmlResolver = resolver;
            doc.Load(reader);
            reader.Close();

        }
    }
}
