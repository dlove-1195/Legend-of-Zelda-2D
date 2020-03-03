using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class AppearRightState: IitemState
    {
       
            private Iitem linkItem;

        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private Texture2D textureBow = Texture2DStorage.GetBowSpriteSheet();
        private Texture2D textureBoomer = Texture2DStorage.GetWoodBoomerangSpriteSheet();
        private Texture2D textureBlueCandle = Texture2DStorage.GetBlueCandleSpriteSheet();
        private int num;



            public AppearRightState(Iitem item)
            {
                this.linkItem = item;
                num = item.getItem();
              
                if (num == 0)
                {
                linkItem.changeSprite(new ArrowRight(texture));
                }
                else if (num == 1)
                {
                linkItem.changeSprite(new BlueCandleUpRight(textureBlueCandle));
                }
                else if (num == 2)
                {
                linkItem.changeSprite(new BombInitialSprite(texture));
                }
                else if (num == 3)
                {
                linkItem.changeSprite(new BowLeft(textureBow));
                }
                else if (num == 4)
                {
                linkItem.changeSprite(new WoodenSwordRight(texture));
                }
                else if (num == 5)
                {
                linkItem.changeSprite(new WoodBoomerangRight(textureBoomer));
                }
            else if (num == 5)
            {
                linkItem.changeSprite(new ItemFireballMoveRightSprite(texture));
            }
        }
          
            public void ChangeToDisappear()
            {
            linkItem.changeState(new DisappearState(linkItem));
            }

        }
    }
