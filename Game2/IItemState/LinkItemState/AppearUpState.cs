using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class AppearUpState : IItemState
    {

        private Iitem linkItem;

        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private Texture2D textureBow = Texture2DStorage.GetBowSpriteSheet();
        private Texture2D textureBoomer = Texture2DStorage.GetWoodBoomerangSpriteSheet();
        private Texture2D textureBlueCandle = Texture2DStorage.GetBlueCandleSpriteSheet();
        private Texture2D texturesword = Texture2DStorage.GetLinkSpriteSheet();
        private Texture2D textureFire = Texture2DStorage.GetEnemySpriteSheet2();
        int num;



        public AppearUpState(Iitem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            this.linkItem = item;
            num = item.getItem();

            if (num == 0)
            {
                linkItem.changeSprite(new ArrowUp(texture, linkItem));
            }
              if (num == 1)
            {
                linkItem.changeSprite(new BlueCandleDownLeft(textureBlueCandle));
            }
              if (num == 2)
            {
                linkItem.changeSprite(new BombInitialSprite(texture));
            }
             if (num == 3)
            {
                linkItem.changeSprite(new BowUp(textureBow));
            }
             if (num == 4)
            {
                linkItem.changeSprite(new WoodenSwordUp(texturesword, linkItem));
            }
             if (num == 5)
            {
                linkItem.changeSprite(new WoodBoomerangUp(textureBoomer, linkItem));
            }
              if (num == 15)
            {
                linkItem.changeSprite(new ItemFireballMoveUpSprite(textureFire, linkItem));
            }

        }

       


    }
}

