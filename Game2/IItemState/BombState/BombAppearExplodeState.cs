using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class BombAppearExplodeState : IitemState
    {
        private Bomb bomb;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();

        public BombAppearExplodeState(Bomb bomb)
        {
            this.bomb = bomb;
            bomb.bombSprite = new BombExplodeSprite(texture);
        }
      

        public void ChangeToDisappear()
        {
            bomb.state = new BombDisappearState(bomb);
        }

        public void ChangeToExplode()
        {
            //already explode
           
        }
    }
}
