using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class AppearLeftState: IItemState
    {
        private IItem linkItem;
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private Texture2D textureBow = Texture2DStorage.GetBowSpriteSheet();
        private Texture2D textureBoomer = Texture2DStorage.GetWoodBoomerangSpriteSheet();
        private Texture2D textureDamageBoomer = Texture2DStorage.GetHurtBoomerangSpriteSheet();
        private Texture2D textureDamageBow = Texture2DStorage.GetHurtBowSpriteSheet();
        private Texture2D textureDamageFire = Texture2DStorage.GetHurtFireSpriteSheet();
        private Texture2D textureDamageBomb = Texture2DStorage.GetHurtBoomSpriteSheet();

        private Texture2D texturesword = Texture2DStorage.GetLinkSpriteSheet();
        private Texture2D textureFire = Texture2DStorage.GetEnemySpriteSheet2();

        private Texture2D texutreHurtWeapon = Texture2DStorage.GetLinkSpriteSheet2();
        private int num;



        public AppearLeftState(IItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            this.linkItem = item;
            num = item.GetItem();
           
            if (num == 0)
            {
                linkItem.ChangeSprite(new ArrowLeft(texture, linkItem));
            }
             if (num == 1)
            {
                linkItem.ChangeSprite(new blueCandleFireLeft(textureFire, linkItem));
            }
              if (num == 2)
            {
                linkItem.ChangeSprite(new BombInitialSprite(texture));
            }
              if (num == 3)
            {
                
                linkItem.ChangeSprite(new BowLeft(textureBow));
            }
             if (num == 4)
            {
                linkItem.ChangeSprite(new WoodenSwordLeft(texturesword, linkItem));
            }
            if (num == 5)
            {
                linkItem.ChangeSprite(new WoodBoomerangLeft(textureBoomer, linkItem));
            }
            if (num == 6)
            {
                linkItem.ChangeSprite(new DamageWoodenSwordLeft(texutreHurtWeapon, linkItem));
            }
            if (num == 7)
            {
                linkItem.ChangeSprite(new DamageArrowLeft(texutreHurtWeapon, linkItem));
            }
            if (num == 8)
            {
                linkItem.ChangeSprite(new DamageblueCandleFireLeft(textureDamageFire, linkItem));
            }
            if (num == 9)
            {
                linkItem.ChangeSprite(new DamageBombInitialSprite(textureDamageBomb));
            }
            if (num == 10)
            {
                linkItem.ChangeSprite(new DamageWoodBoomerangLeft(textureDamageBoomer, linkItem));
            }
            if (num == 11)
            {
                linkItem.ChangeSprite(new DamageBowLeft(textureDamageBow));
            }
            
            if (num == 15)
            {
                linkItem.ChangeSprite(new ItemFireballMoveLeftSprite(textureFire, linkItem));
            }
            if (num == 16)
            {
                linkItem.ChangeSprite(new ItemSpreadUpFireballMoveLeftSprite(textureFire, linkItem));
            }
            if (num == 17)
            {
                linkItem.ChangeSprite(new ItemSpreadDownFireballMoveLeftSprite(textureFire, linkItem));
            }

        }
       
        

    }
}

