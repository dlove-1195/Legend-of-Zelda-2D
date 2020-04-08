using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Xml;

namespace Sprint2
{
    public class Inventory : IInventory
    {
        public int heartNum { get; set; } = 3;
        public int diamondNum { get; set; } = 0;
        public int keyNum { get; set; } = 0;
        public int bombNum { get; set; } = 0;

        private Vector2 heartPos
        private int heartGapX 
        private int heartGapY 
        private Vector2 diamondPos
        private Vector2 keyPos 
        private Vector2 bombPos 

        public Inventory(IGameState playState) {

            
        }
   /*     Map : heart=>3
            collision detecter handler heart-1
            blue 
        linkDetection = new LinkCollisionDetection(level, player);

        private Matrix<String> 

            for each item in matrix

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
                    if (name == "StaticBomb")
                    {
                        pickUpItems.Add(new staticBomb(vector));
                    }
    }*/
}
