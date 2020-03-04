﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Fairy : Iitem
    {
        private int p = 9;
        //Sprite class parameter
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private int sourceLocX = 124;
        private int sourceLocY = 40;
        private int width = 8;
        private int height = 16;

        //Sprite Object
        public ISprite fairySprite;

        //initial position on the ground
        public int posX = 120;
        public int posY = 400;

        public Fairy()
        {
            fairySprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

        }


        public void Draw(SpriteBatch spriteBatch)
        {
            fairySprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            fairySprite.Update();
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
        public void nextItem(Game1 myGame)
        {


            myGame.item = new Heart();
        }

        public void preItem(Game1 myGame)
        {

            myGame.item = new Compass();
        }
    }
}