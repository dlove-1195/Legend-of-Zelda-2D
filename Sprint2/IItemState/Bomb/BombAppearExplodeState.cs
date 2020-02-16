﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class BombAppearExplodeState : IBombitemstate
    {
        private Bomb bomb;
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();

        public BombAppearExplodeState(Bomb bomb)
        {
            this.bomb = bomb;
            bomb.bombSprite = new BombExplodeSprite(texture);
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
            //already explode
            throw new NotImplementedException();
        }
    }
}