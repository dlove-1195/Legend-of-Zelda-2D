﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    class BlueDiamond : Iitem
    {
        public Iitemstate state;
        public ISprite blueDiamondSprite;
        //initial position on the ground
        public int posX;
        public int posY;
        public BlueDiamond()
        {
            //constructor
        }
        public void Appear()
        {
            
        }

        public void Disappear()
        {
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            blueDiamondSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}