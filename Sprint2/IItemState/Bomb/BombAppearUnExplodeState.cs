﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class BombAppearUnExplodeState : IBombitemstate
    {
        private Bomb bomb;
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();

        public BombAppearUnExplodeState(Bomb bomb)
        {
            this.bomb = bomb;
            Console.WriteLine("make it to the initial part");
            bomb.bombSprite = new BombInitialSprite(texture);
        }
        public void ChangeToAppear()
        {
            //already appear, do nothing
        }

        public void ChangeToDisappear()
        {
            bomb.state = new BombDisappearState(bomb);
        }

        public void ChangeToExplode()
        {
            bomb.state = new BombAppearExplodeState(bomb);
        }
    }
}
