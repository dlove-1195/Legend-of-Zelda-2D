﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
   public class AppearDownState: IItemState
    {
        private IItem linkItem;

        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private Texture2D textureBow = Texture2DStorage.GetBowSpriteSheet();
        private Texture2D textureBoomer = Texture2DStorage.GetWoodBoomerangSpriteSheet();

        private Texture2D textureDamageBoomer = Texture2DStorage.GetHurtBoomerangSpriteSheet();
        private Texture2D textureDamageBow = Texture2DStorage.GetHurtBowSpriteSheet();
        private Texture2D textureDamageFire = Texture2DStorage.GetHurtFireSpriteSheet();
        private Texture2D textureDamageBomb = Texture2DStorage.GetHurtBoomSpriteSheet();


        private Texture2D textureFire = Texture2DStorage.GetEnemySpriteSheet2();
        private Texture2D texturesword = Texture2DStorage.GetLinkSpriteSheet();
        //damageSword & damage arrow
        private Texture2D texutreHurtWeapon = Texture2DStorage.GetHurtWeaponSpriteSheet(); 
        int num;

      

        public AppearDownState(IItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            this.linkItem = item;
            num = item.GetItem();
           
            if(num == 0)
            {
                linkItem.ChangeSprite(new ArrowDown(texture, linkItem));
            }
             if(num == 1)
            {
                linkItem.ChangeSprite(new blueCandleFireDown ( textureFire,linkItem));
            }
             if(num == 2)
            {
                linkItem.ChangeSprite(new BombInitialSprite(texture));
            }
            if(num == 3)
            {
                linkItem.ChangeSprite(new BowDown(textureBow));
            }
            if(num == 4)
            {
                linkItem.ChangeSprite(new WoodenSwordDown(texturesword, linkItem));
            }
             if(num == 5)
            {
                linkItem.ChangeSprite(new WoodBoomerangDown(textureBoomer,linkItem));
            }
            if(num == 6)
            {
                linkItem.ChangeSprite(new DamageWoodenSwordDown(texutreHurtWeapon, linkItem));
            }
            if(num == 7)
            {
                linkItem.ChangeSprite(new DamageArrowDown(texutreHurtWeapon, linkItem));
            }
            if (num == 8)
            {
                linkItem.ChangeSprite(new DamageblueCandleFireDown(textureDamageFire, linkItem));
            }
            if (num == 9)
            {
                linkItem.ChangeSprite(new DamageBombInitialSprite(textureDamageBomb));
            }
            if(num == 10)
            {
                linkItem.ChangeSprite(new DamageWoodBoomerangDown(textureDamageBoomer, linkItem));
            }
            if (num == 15)
            {
                
                linkItem.ChangeSprite(new ItemFireballMoveDownSprite(textureFire, linkItem));
              

            }
        }
      
      
    }
}
