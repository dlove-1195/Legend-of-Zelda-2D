using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Xml;

//set itemB using inventoryBar object by inventoryBar.itemB = "string"
//please add inventoryBar.heartNum--; 
//and inventoryBar.itemList.add("item-name"); in link collision handler
//also in command when using bomb, key, items, inventoryBar.bombNum--; keyNum--; etc. if num<=0 do nothing

namespace Sprint2
{
    public class Inventory : IInventory
    {

        private Texture2D inventoryTexture = Texture2DStorage.GetNumberSpriteSheet();

        public int heartNum { get; set; } = 12;
        public int diamondNum { get; set; } =10;
        public int keyNum { get; set; } = 0;
        public int bombNum { get; set; } = 0;


        public string itemA { get; set; } = "sword";
        public string itemB { get; set; } = "bomb";


        public Array itemList { get; set; } = new string[] { "bomb","boomerang","bow","candle","candle" };
        public string itemSelect { get; set; } = "bomb";



        private static int width = 800;
        private static int height = 200;
        private Vector2 heartPos = new Vector2(width-213, height-94);


        private Number DiamondNum;
        private Number KeyNum;
        private Number BombNum;



        private Dictionary<string, Vector2> itemMap = new Dictionary<string, Vector2>(){
            {"sword", new Vector2 (64,52)},
            { "bomb", new Vector2 (148,53)},
            { "bow",new Vector2(197,54)},
            { "boomerang",new Vector2(115,54)},
            { "candle",new Vector2(216,53)}
            };

        //private IGameState playState;

        public Inventory(PlayState playState)
        {
           // playState = playState;
            // linkDetection = playState.linkDetection;
            DiamondNum = new Number(diamondNum, new Vector2(width - 483, height - 132));
            KeyNum = new Number(keyNum, new Vector2(width - 482, height - 80));
            BombNum = new Number(bombNum, new Vector2(width - 482, height - 48));

        }

        public void Update() {
            // playState.Update();
            //if(playState.linkDetection)
            DiamondNum.Update();
             KeyNum.Update();
            BombNum.Update();

    }
        public void Draw(SpriteBatch spriteBatch,int y) {

            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }

            DrawNumber(spriteBatch,y);
            DrawItemA(spriteBatch,y);
            DrawItemB(spriteBatch,y);
            DrawHeart(spriteBatch,y);

            if (y == 600) {
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


        private void DrawSelectBox(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle1 = new Rectangle((int)itemMap[itemSelect].X, (int)itemMap[itemSelect].Y, 14, 25);
            Rectangle destinationRectangle = new Rectangle(187,257-71, 36, 58);
            spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
        }



        //how many new number objects are layered, and is it updated in playstate, when updating inventoryBar
        private void DrawNumber(SpriteBatch spriteBatch,int y) {
            
            DiamondNum.Draw(spriteBatch,y);
            KeyNum.Draw(spriteBatch,y);
            BombNum.Draw(spriteBatch,y);
    }

        private void DrawItemA(SpriteBatch spriteBatch,int y) {
            Rectangle sourceRectangle1 = new Rectangle(66, 52, 14, 30);
            Rectangle destinationRectangle = new Rectangle(width - 330, height - 101+y, 36, 58);
            spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
        }

        private void DrawItemB(SpriteBatch spriteBatch,int y) {
            if (itemB != null)
            {
                Rectangle sourceRectangle1 = new Rectangle((int)itemMap[itemB].X,(int)itemMap[itemB].Y, 14, 25);
                Rectangle destinationRectangle = new Rectangle(width - 410, height - 101+y, 36, 58);
                spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
            }
            
        }

        //maximum 14 hearts
        private void DrawHeart(SpriteBatch spriteBatch,int y)
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
