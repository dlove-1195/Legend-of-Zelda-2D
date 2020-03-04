using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
   public class AppearDownState:IitemState
    {
        private Iitem linkItem;

        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private Texture2D textureBow = Texture2DStorage.GetBowSpriteSheet();
        private Texture2D textureBoomer = Texture2DStorage.GetWoodBoomerangSpriteSheet();
       private Texture2D textureBlueCandle = Texture2DStorage.GetBlueCandleSpriteSheet();
        int num;

      

        public AppearDownState(Iitem item)
        {
            this.linkItem = item;
            num = item.getItem();
           
            if(num == 0)
            {
                linkItem.changeSprite(new ArrowDown(texture));
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
                linkItem.changeSprite(new WoodenSwordDown(texture));
            }
             if(num == 5)
            {
                linkItem.changeSprite(new WoodBoomerangDown(textureBoomer));
            }
            if (num == 15)
            {
                
                linkItem.changeSprite(new ItemFireballMoveDownSprite(texture));
              

            }
        }
      
        public void ChangeToDisappear()
        {
            linkItem.changeState(new DisappearState(linkItem));
        }

    }
}
