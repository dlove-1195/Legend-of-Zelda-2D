using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class BombAppearExplodeState:IItemState
    {
        private Bomb bomb;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();

        public BombAppearExplodeState(Bomb bomb)
        {
            if (bomb == null)
            {
                throw new ArgumentNullException(nameof(bomb));
            }
            this.bomb = bomb;
            bomb.bombSprite = new BombExplodeSprite(texture);
        }
      

         
        public static void ChangeToExplode()
        {
            //already explode
           
        }
    }
}
