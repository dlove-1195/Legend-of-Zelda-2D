using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
 

 
namespace Sprint2
{
    public class Inventory : IInventory
    {
       
        private Texture2D inventoryTexture = Texture2DStorage.GetNumberSpriteSheet();

        public int heartNum { get; set; } = 12;
        public int diamondNum { get; set; } =10;
        public int keyNum { get; set; } = 0;
        public int bombNum { get; set; } = 0;
        public int triPieceNum { get; set; } = 0;

        public string itemA { get; set; } = "sword";
        public string itemB { get; set; }

        // being initialized as empty 
        //"bomb","boomerang","bow","candle","candle"
        public List<String> itemList { get; set; } = new List<String>();
        public int currentIndex { get; set; } = 0;
        public string itemSelect { get; set; }  


        //the width and height for the bar rectangle 
        private static int width = 800;
        private static int height = 200;
        private Vector2 heartPos = new Vector2(width-213, height-94);
        public bool barOnly { get; set; } = true;
        NumberGenerator generator = new NumberGenerator();
        private int y = 0;
         

        //the coordination for each item in the item selet bar
        private Dictionary<string, Vector2> itemMap = new Dictionary<string, Vector2>(){
            {"sword", new Vector2 (64,52)},
            { "bomb", new Vector2 (148,53)},
            { "bow",new Vector2(197,54)},
            { "boomerang",new Vector2(115,54)},
            { "candle",new Vector2(216,53)}
            };

        //room map on the top position of inventory sprite sheet 
        //int represents room number
        //width=height=19
        private Dictionary<int, Vector2> upRoomMap = new Dictionary<int, Vector2>()
        {
            { 1, new Vector2 (478,507)},
            { 2, new Vector2 (478,480)},
            { 3,new Vector2(452,480)},
            { 4,new Vector2(425,533)},
            { 5,new Vector2(452,533)},
            { 6, new Vector2 (452,560)},
            { 7, new Vector2 (532,533)},
            { 8,new Vector2(478,560)},
            { 9,new Vector2(505,560)},
            { 10,new Vector2(425,560)},
            { 11, new Vector2 (505,533)},
            { 12, new Vector2 (532,560)},
            { 13,new Vector2(425,587)},
            { 14,new Vector2(478,613)},
            { 15,new Vector2(425,480)},
            { 16, new Vector2 (532,507)},
            { 17, new Vector2 (478,533)},
            { 18,new Vector2(478,587)},
            { 19,new Vector2(505,613)}
        };


        //room map on the bottom position of inventory sprite sheet 
        //int represents room number
        //width=22, height =10
        private Dictionary<int, Vector2> downRoomMap = new Dictionary<int, Vector2>()
        {
            { 1, new Vector2 (102,783)},
            { 2, new Vector2 (102,770)},
            { 3,new Vector2(75,770)},
            { 4,new Vector2(49,796)},
            { 5,new Vector2(75,796)},
            { 6, new Vector2 (75,810)},
            { 7, new Vector2 (155,796)},
            { 8,new Vector2(102,810)},
            { 9,new Vector2(129,810)},
            { 10,new Vector2(49,810)},
            { 11, new Vector2 (129,796)},
            { 12, new Vector2 (155,810)},
            { 13,new Vector2(49,823)},
            { 14,new Vector2(102,836)},
            { 15,new Vector2(49,770)},
            { 16, new Vector2 (155,783)},
            { 17, new Vector2 (102,796)},
            { 18,new Vector2(102,823)},
            { 19,new Vector2(129,836)}
        };

        public Inventory()
        {

            //bar area
           
           /* DiamondNum = new Number(diamondNum, new Vector2(width - 483, height - 132));
            KeyNum = new Number(keyNum, new Vector2(width - 482, height - 80));
            BombNum = new Number(bombNum, new Vector2(width - 482, height - 48));*/

        }

        public void Update() {
            //only needed if we want to implement dot blicking in the map
            if (barOnly)
            {
                y = 0;
            }
            else
            {
                y = 600;
            }
            if (itemList.Count > 0)
            {
                itemB = itemList[currentIndex];
            }

    }
        public void Draw(SpriteBatch spriteBatch ) {

            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }

            //drawing in the bar area
            DrawNumber(spriteBatch);
            DrawItemA(spriteBatch);
            DrawItemB(spriteBatch);
            DrawHeart(spriteBatch);

            if (!barOnly) {
                DrawItem(spriteBatch);
                DrawSelectBox(spriteBatch);

            }
              


            

        }


        private void DrawItem(SpriteBatch spriteBatch)
        {
            int i = 0;
            foreach (string item in itemList)
            {
                Rectangle sourceRectangle1 = new Rectangle((int)itemMap[item].X, (int)itemMap[item].Y, 14, 25);
                if (i < 4)
                {
                    Rectangle destinationRectangle = new Rectangle(411 + i * 60, 206, 24, 48);
                    spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
                }
                else {
                    Rectangle destinationRectangle = new Rectangle(411 + (i-4) * 60, 206+52, 24, 48);
                    spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
                }
                i++;
            }
        }


        //for item selector view box
        private void DrawSelectBox(SpriteBatch spriteBatch)
        { if (itemB != null)
            {
                Rectangle sourceRectangle1 = new Rectangle((int)itemMap[itemB].X, (int)itemMap[itemB].Y, 14, 25);
                Rectangle destinationRectangle = new Rectangle(187, 257 - 71, 36, 58);
                spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
            }
        }



         
        //how many new number objects are layered, and is it updated in playstate, when updating inventoryBar
        private void DrawNumber(SpriteBatch spriteBatch ) {


            generator.DrawSingleNumber(spriteBatch, barOnly, new Vector2(width - 483, height - 132), diamondNum);
            generator.DrawSingleNumber(spriteBatch, barOnly, new Vector2(width - 482, height - 80), keyNum);
            generator.DrawSingleNumber(spriteBatch, barOnly, new Vector2(width - 482, height - 48), bombNum );

        }

        private void DrawItemA(SpriteBatch spriteBatch ) {
            Rectangle sourceRectangle1 = new Rectangle(66, 52, 14, 30);
            Rectangle destinationRectangle = new Rectangle(width - 330, height - 101+y, 36, 58);
            spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
        }

        //for final selected item
        private void DrawItemB(SpriteBatch spriteBatch ) {
            if (itemSelect != null)
            {
                Rectangle sourceRectangle1 = new Rectangle((int)itemMap[itemSelect].X,(int)itemMap[itemSelect].Y, 14, 25);
                Rectangle destinationRectangle = new Rectangle(width - 410, height - 101+y, 36, 58);
                spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
            }
            
        }

        //maximum 14 hearts
        private void DrawHeart(SpriteBatch spriteBatch )
        {
            for (int i = 0; i < heartNum; i++)
            {
                Rectangle sourceRectangle1 = new Rectangle(218, 20, 12, 12);
                if (i < 7)
                {
                    Rectangle destinationRectangle = new Rectangle((int)heartPos.X + i * 30, (int)heartPos.Y+y, 30, 30);
                    spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
                }
                else {
                    Rectangle destinationRectangle2 = new Rectangle((int)heartPos.X + (i-7) * 30, (int)heartPos.Y+32+y, 30, 30);
                    spriteBatch.Draw(inventoryTexture, destinationRectangle2, sourceRectangle1, Color.White);
                }
            }
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
}
