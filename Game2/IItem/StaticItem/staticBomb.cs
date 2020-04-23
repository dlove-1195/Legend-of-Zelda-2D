﻿ 
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
    {
        class staticBomb : IItem
        {
            public int Count { get; set; } = 0;
            public int TotalCount { get; set; } = 100;
            public bool Appear { get; set; } = false;
            private int p = 15;
            //Sprite parameter
            private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
            private int sourceLocX = 204;
            private int sourceLocY = 1;
            private int width = 8;
            private int height = 14;
            public Rectangle BoundingBox { get; set; }
            //Sprite Object
            public ISprite mapSprite;

            //initial position in the center
            public int PosX { get; set; }
            public int PosY { get; set; }

            public staticBomb(Vector2 vector)
            {
                PosX = (int)vector.X;
                PosY = (int)vector.Y;
                mapSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

            }

            public void Draw(SpriteBatch spriteBatch)
            {
                mapSprite.Draw(spriteBatch, new Vector2(PosX, PosY));
            }

            public void Update()
            {
                BoundingBox = new Rectangle(PosX, PosY, width * 3, height * 3);
                mapSprite.Update();
            }
            public int GetItem()
            {
                return p;
            }
            public void changeState()
            {
                //do nothing
            }

            public void ChangeSprite(ISprite sprite)
            {
                //do nothing
            }
            public void PreItem(Game1 myGame)
            {

                 

            }
            public void NextItem(Game1 myGame)
            {

                

            }
        }
    }
 