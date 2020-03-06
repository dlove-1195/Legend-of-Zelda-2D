﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace Sprint2
{
    public class Key : Iitem
    {
        private int p = 12;
        //Sprite parameter
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private int sourceLocX = 284;
        private int sourceLocY = 40;
        private int width = 8;
        private int height = 16;
        public Rectangle boundingBox { get; set; }
        //Sprite Object
        public ISprite keySprite;

        //initial position in the center
        public int posX;
        public int posY;

        public Key(Vector2 vector)
        {
            vector.X = posX;
            vector.Y = posY;

            keySprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            keySprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
            keySprite.Update();
        }
        public int getItem()
        {
            return p;
        }
        public void changeState(IitemState state)
        {
            //do nothing
        }

        public void changeSprite(ISprite sprite)
        {
            //do nothing
        }
        public void preItem(Game1 myGame)
        {

            myGame.item = new HeartContainer();

        }
        public void nextItem(Game1 myGame)
        {

            myGame.item = new Map();

        }
    }
}
