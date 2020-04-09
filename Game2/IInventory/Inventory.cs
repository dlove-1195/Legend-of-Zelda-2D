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

        private Texture2D inventoryTexture = Texture2DStorage.GetNumberSpriteSheet();

        public int heartNum { get; set; } = 3;
        public int diamondNum { get; set; } =10;
        public int keyNum { get; set; } = 0;
        public int bombNum { get; set; } = 0;

        private Number DiamondNum;
        private Number KeyNum;
        private Number BombNum;


        public string itemA { get; set; } = "sword";
        public string itemB { get; set; } = null;

        private Vector2 heartPos = new Vector2(409, 66);
        private int heartGapX = 32;
        private int heartGapY = 35;
        private Vector2 diamondPos = new Vector2(349, 43);
        private Vector2 keyPos = new Vector2(349, 72);
        private Vector2 bombPos = new Vector2(349, 92);

        //size in item list
        private Vector2 itemBox = new Vector2(16, 29);

        private static int width = 800;
        private static int height = 200;

        private Dictionary<string, Vector2> itemMap = new Dictionary<string, Vector2>(){
            {"sword", new Vector2 (64,52)},
            { "bomb", new Vector2 (147,51)}
            };

        private IGameState playState;

        public Inventory(IGameState playState)
        {
            //playState = playState;
            // linkDetection = playState.linkDetection;
            DiamondNum = new Number(diamondNum, new Vector2(width - 483, height - 132));
            KeyNum = new Number(keyNum, new Vector2(width - 482, height - 80));
            BombNum = new Number(bombNum, new Vector2(width - 482, height - 48));

        }

        public void Update() {
            // playState.Update();

            DiamondNum.Update();
             KeyNum.Update();
            BombNum.Update();

    }
        public void Draw(SpriteBatch spriteBatch) {

            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }

            DrawNumber(spriteBatch);
            DrawItemA(spriteBatch);
    
              
            //draw heart

            

        }

        //how many new number objects are layered, and is it updated in playstate, when updating inventoryBar
        private void DrawNumber(SpriteBatch spriteBatch) {
            
            DiamondNum.Draw(spriteBatch);
            KeyNum.Draw(spriteBatch);
            BombNum.Draw(spriteBatch);
    }

        private void DrawItemA(SpriteBatch spriteBatch) {
            Rectangle sourceRectangle1 = new Rectangle(64, 52, 16, 29);
            Rectangle destinationRectangle = new Rectangle(width - 330, height - 101, 36, 58);
            spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
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
