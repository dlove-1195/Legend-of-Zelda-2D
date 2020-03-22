using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
   public class AppearDownState:IItemState
    {
        private Iitem linkItem;

        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private Texture2D textureBow = Texture2DStorage.GetBowSpriteSheet();
        private Texture2D textureBoomer = Texture2DStorage.GetWoodBoomerangSpriteSheet();
       private Texture2D textureBlueCandle = Texture2DStorage.GetBlueCandleSpriteSheet();
        private Texture2D textureFire = Texture2DStorage.GetEnemySpriteSheet2();
        private Texture2D texturesword = Texture2DStorage.GetLinkSpriteSheet();
        int num;

      

        public AppearDownState(Iitem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            this.linkItem = item;
            num = item.getItem();
           
            if(num == 0)
            {
                linkItem.changeSprite(new ArrowDown(texture, linkItem));
            }
             if(num == 1)
            {
                linkItem.changeSprite(new BlueCandleDownLeft(textureBlueCandle));
            }
             if(num == 2)
            {
                linkItem.changeSprite(new BombInitialSprite(texture));
            }
            if(num == 3)
            {
                linkItem.changeSprite(new BowDown(textureBow));
            }
            if(num == 4)
            {
                linkItem.changeSprite(new WoodenSwordDown(texturesword, linkItem));
            }
             if(num == 5)
            {
                linkItem.changeSprite(new WoodBoomerangDown(textureBoomer,linkItem));
            }
            if (num == 15)
            {
                
                linkItem.changeSprite(new ItemFireballMoveDownSprite(textureFire, linkItem));
              

            }
        }
      
      
    }
}
