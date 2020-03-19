using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class BombAppearUnExplodeState  : IitemState
    {
        private Bomb bomb;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();

        public BombAppearUnExplodeState(Bomb bomb)
        {
            this.bomb = bomb;
             
            bomb.bombSprite = new BombInitialSprite(texture);
        }
     

       

        public void ChangeToExplode()
        {
            bomb.state = new BombAppearExplodeState(bomb);
        }
    }
}
