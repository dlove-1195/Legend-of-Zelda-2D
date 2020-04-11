using System;
using System.Collections.Generic; 
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;



namespace Sprint2
{
    public class Inventory : IInventory
    {

        private Texture2D inventoryTexture = Texture2DStorage.GetNumberSpriteSheet();
        private Texture2D barMapTexture = Texture2DStorage.GetDownMapSpriteSheet();
        private Texture2D inventoryMapTexture = Texture2DStorage.GetUpMapSpriteSheet();
        

        public int heartNum { get; set; } = 12;
        public int diamondNum { get; set; } = 10;
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
        private Vector2 heartPos = new Vector2(width - 213, height - 94);
        public bool barOnly { get; set; } = true; 
        private int y = 0;
        private ISprite mapSprite = new StaticSprite(Texture2DStorage.GetItemSpriteSheet(), 244,80,8,16);
        private ISprite compassSprite = new StaticSprite(Texture2DStorage.GetItemSpriteSheet(), 82, 42, 11, 12);
        //assume triforce are being set in room 14,15,16
        private ISprite triforceDotSprite1 = new ShiningDotSprite(Texture2DStorage.GetItemSpriteSheet(), 343, 123, 10, 10);
        private ISprite triforceDotSprite2 = new ShiningDotSprite(Texture2DStorage.GetItemSpriteSheet(), 343, 123, 10, 10);
        private ISprite triforceDotSprite3 = new ShiningDotSprite(Texture2DStorage.GetItemSpriteSheet(), 343, 123, 10, 10);
        private ISprite linkPosDotSprite = new ShiningDotSprite(Texture2DStorage.GetNumberSpriteSheet(), 34, 35, 7, 5);
        public bool showMap { get; set; } = false;
        public bool showCompass { get; set; } = false;


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
            { 1, new Vector2 (478,407)},
            { 2, new Vector2 (478,380)},
            { 3,new Vector2(452,380)},
            { 4,new Vector2(425,433)},
            { 5,new Vector2(452,433)},
            { 6, new Vector2 (452,460)},
            { 7, new Vector2 (532,433)},
            { 8,new Vector2(478,460)},
            { 9,new Vector2(505,460)},
            { 10,new Vector2(425,460)},
            { 11, new Vector2 (505,433)},
            { 12, new Vector2 (532,460)},
            { 13,new Vector2(425,487)},
            { 14,new Vector2(478,513)},
            { 15,new Vector2(425,380)},
            { 16, new Vector2 (532,407)},
            { 17, new Vector2 (478,433)},
            { 18,new Vector2(478,487)},
            { 19,new Vector2(505,513)} 
         } ;
     


        //room map on the bottom position of inventory sprite sheet 
        //int represents room number
        //width=22, height =10
        private Dictionary<int, Vector2> downRoomMap = new Dictionary<int, Vector2>()
        {
            { 1, new Vector2 (102,123)},
            { 2, new Vector2 (102,110)},
            { 3,new Vector2(75,110)},
            { 4,new Vector2(49,136)},
            { 5,new Vector2(75,136)},
            { 6, new Vector2 (75,150)},
            { 7, new Vector2 (155,136)},
            { 8,new Vector2(102,150)},
            { 9,new Vector2(129,150)},
            { 10,new Vector2(49,150)},
            { 11, new Vector2 (129,136)},
            { 12, new Vector2 (155,150)},
            { 13,new Vector2(49,163)},
            { 14,new Vector2(102,176)},
            { 15,new Vector2(49,110)},
            { 16, new Vector2 (155,123)},
            { 17, new Vector2 (102,136)},
            { 18,new Vector2(102,163)},
            { 19,new Vector2(129,176)}
        };

        private List<IRoom> existingRooms;
        private PlayState play;
        private int currentRoom;
        public Inventory(PlayState play)
        {
            this.play = play;
               
        }

        public void Update()
        {
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
            existingRooms = play.level.existingRooms;
            currentRoom = play.level.currentRoomNum;
            if (showMap && showCompass)
            {
                //need to update compass
                triforceDotSprite1.Update();
                triforceDotSprite2.Update();
                triforceDotSprite3.Update();
            }
            linkPosDotSprite.Update();

        }
        public void Draw(SpriteBatch spriteBatch)
        {

            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }

            //drawing in the bar area
            DrawNumber(spriteBatch);
            DrawItemA(spriteBatch);
            DrawItemB(spriteBatch);
            DrawHeart(spriteBatch);
            if (!showMap)
            {
                DrawRoomDown(spriteBatch);
            }
            else
            {  
                drawEntireMapDown(spriteBatch);
                if (showCompass)
                {
                    //draw triforce dot
                    triforceDotSprite1.Draw(spriteBatch,new Vector2(107,170+y));//in room14
                    triforceDotSprite2.Draw(spriteBatch, new Vector2(54,110+y)); //in room15
                    triforceDotSprite3.Draw(spriteBatch, new Vector2(157,120+y)); //in room16
                }
                 
            }

            if (!barOnly)
            {
                DrawItem(spriteBatch);
                DrawSelectBox(spriteBatch);
                DrawSelector(spriteBatch);
                if (showCompass)
                {
                    //draw compass
                    compassSprite.Draw(spriteBatch, new Vector2(120, 520));
                }
                if (!showMap)
                {
                    DrawRoomUp(spriteBatch);
                }
                else
                {
                    drawEntireMapUp(spriteBatch);
                    mapSprite.Draw(spriteBatch, new Vector2(120, 400));
                    if (showCompass)
                    { 
                        //draw triforce dot
                        triforceDotSprite1.Draw(spriteBatch, new Vector2(483,518));//in room14
                        triforceDotSprite2.Draw(spriteBatch, new Vector2(430, 385)); //in room15
                        triforceDotSprite3.Draw(spriteBatch, new Vector2(537, 412)); //in room16
                         
                    }
                }

            }

            DrawLinkPosDotDownRoom(spriteBatch);
            DrawLinkPosDotUpRoom(spriteBatch);




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
                else
                {
                    Rectangle destinationRectangle = new Rectangle(411 + (i - 4) * 60, 206 + 52, 24, 48);
                    spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
                }
                i++;
            }
        }

        private void DrawSelector(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(4, 54, 26, 26);
            
            if (itemList.Count>0 )
            {
                int i = currentIndex;
                if (i < 4)
                {
                    Rectangle destinationRectangle = new Rectangle(411 + i * 60 - 3, 206 - 3, 30, 54);
                    spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle, Color.White);
                }
                else
                {
                    Rectangle destinationRectangle = new Rectangle(411 + (i - 4) * 60 - 3, 206 + 52 - 3, 30, 54);
                    spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle, Color.White);
                }
            }

          
        }

        //for item selector view box
        private void DrawSelectBox(SpriteBatch spriteBatch)
        {
            if (itemB != null)
            {
                Rectangle sourceRectangle1 = new Rectangle((int)itemMap[itemB].X, (int)itemMap[itemB].Y, 14, 25);
                Rectangle destinationRectangle = new Rectangle(187, 257 - 71, 36, 58);
                spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
            }
        }




        //how many new number objects are layered, and is it updated in playstate, when updating inventoryBar
        private void DrawNumber(SpriteBatch spriteBatch)
        {


           NumberGenerator.DrawSingleNumber(spriteBatch, barOnly, new Vector2(width - 483, height - 132), diamondNum);
            NumberGenerator.DrawSingleNumber(spriteBatch, barOnly, new Vector2(width - 482, height - 80), keyNum);
            NumberGenerator.DrawSingleNumber(spriteBatch, barOnly, new Vector2(width - 482, height - 48), bombNum);

        }

        private void DrawItemA(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle1 = new Rectangle(66, 52, 14, 30);
            Rectangle destinationRectangle = new Rectangle(width - 330, height - 101 + y, 36, 58);
            spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
        }

        //for final selected item
        private void DrawItemB(SpriteBatch spriteBatch)
        {
            if (itemSelect != null)
            {
                Rectangle sourceRectangle1 = new Rectangle((int)itemMap[itemSelect].X, (int)itemMap[itemSelect].Y, 14, 25);
                Rectangle destinationRectangle = new Rectangle(width - 410, height - 101 + y, 36, 58);
                spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
            }

        }

        //maximum 14 hearts
        private void DrawHeart(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < heartNum; i++)
            {
                Rectangle sourceRectangle1 = new Rectangle(218, 20, 12, 12);
                if (i < 7)
                {
                    Rectangle destinationRectangle = new Rectangle((int)heartPos.X + i * 30, (int)heartPos.Y + y, 30, 30);
                    spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
                }
                else
                {
                    Rectangle destinationRectangle2 = new Rectangle((int)heartPos.X + (i - 7) * 30, (int)heartPos.Y + 32 + y, 30, 30);
                    spriteBatch.Draw(inventoryTexture, destinationRectangle2, sourceRectangle1, Color.White);
                }
            }
        }

        //width=height=19
        private void DrawRoomUp(SpriteBatch spriteBatch )
        {
            if (existingRooms != null)
            {  
                Rectangle sourceRectangle = new Rectangle(31, 11, 19, 19);
                for (int i = 0; i < existingRooms.Count; i++)
                {
                  
                        int desX = (int)upRoomMap[existingRooms[i].roomNumber].X;
                        int desY = (int)upRoomMap[existingRooms[i].roomNumber].Y;
                        Rectangle destinationRectangle = new Rectangle(desX, desY, 19, 19);
                        spriteBatch.Draw(inventoryMapTexture, destinationRectangle, sourceRectangle, Color.White);
                     
                }
            }
        }

        
         
        //width=24, height =11
        private void DrawRoomDown(SpriteBatch spriteBatch )
        {
            if (existingRooms != null)
            {
                Rectangle sourceRectangle = new Rectangle(20, 6, 24, 11);
                for (int i = 0; i < existingRooms.Count; i++)
                {
                    
                        int desX = (int)downRoomMap[existingRooms[i].roomNumber].X;
                        int desY = (int)downRoomMap[existingRooms[i].roomNumber].Y;
                        Rectangle destinationRectangle = new Rectangle(desX, desY + y, 24, 11);
                        spriteBatch.Draw(barMapTexture, destinationRectangle, sourceRectangle, Color.White);
                    
                }
            }
        }

        private void drawEntireMapUp(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(31, 11, 128, 155);
            Rectangle destinationRectangle = new Rectangle(425, 380 , 133, 152);
            spriteBatch.Draw(inventoryMapTexture, destinationRectangle, sourceRectangle, Color.White);
        }

        private void drawEntireMapDown(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(20, 6, 131, 78);
            Rectangle destinationRectangle = new Rectangle(49, 110 + y, 120, 66);
            spriteBatch.Draw(barMapTexture, destinationRectangle, sourceRectangle, Color.White);
        }
        private void DrawLinkPosDotUpRoom(SpriteBatch spriteBatch)
        {
            if (existingRooms != null)
            {
                int desX = (int)upRoomMap[currentRoom].X;
                int desY = (int)upRoomMap[currentRoom].Y;
                linkPosDotSprite.Draw(spriteBatch, new Vector2((int)(desX + 7), (int)(desY + 5))); //current room
            }
        }
        private void DrawLinkPosDotDownRoom(SpriteBatch spriteBatch)
        {
            if (existingRooms != null)
            {
                int desX = (int)downRoomMap[currentRoom].X;
                int desY = (int)downRoomMap[currentRoom].Y;
                linkPosDotSprite.Draw(spriteBatch, new Vector2((int)(desX + 10), (int)(desY + 3 + y))); //current room
            }
        }
    }
    }
 