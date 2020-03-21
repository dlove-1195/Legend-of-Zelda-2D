using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class LinkWithItemLeftState : Iplayerstate
    {
       
        private Link link;
        private Texture2D textureLink = Texture2DStorage.GetLinkSpriteSheet();
        public LinkWithItemLeftState(Link link, int itemNum)
        {

            this.link = link;
            link.ChangeDirection(2);
            
            switch (itemNum )
            {
                case 0:
                    //arrow
                    link.linkSprite = new LinkStandLeftSprite(textureLink);
                     Iitem item0 = new Arrow((Link.posX - 20), Link.posY, 2);
                    Iitem bow = new Bow((Link.posX - 20), Link.posY, 2);
                    item0.appear = true;
                    bow.appear =true;
                    link.items.Add(item0);
                    link.items.Add(bow);
                    break;
                case 1:
                    //blue candle
                    link.linkSprite = new LinkStandLeftSprite(textureLink);
                    Iitem item1 = new BlueCandle((Link.posX - 20), Link.posY, 2);
                    item1.appear = true;
                    link.items.Add(item1);
                    break;
                case 2:
                    //bomb
                    link.linkSprite = new LinkStandLeftSprite(textureLink);
                    Iitem item2 = new Bomb((Link.posX - 20), Link.posY);
                   
                    item2.appear = true;
                    link.items.Add(item2);
                    break;

                case 3:
                   
                    break;
                case 4:
                    //sword
                    link.linkSprite = new LinkAttackLeftSprite(textureLink);
                    Iitem item4 = new Sword((Link.posX - 20), Link.posY, 2);
                   
                    item4.appear = true;
                    link.items.Add(item4);
                    break;
                case 5:
                    //Boomerang
                    link.linkSprite = new LinkStandLeftSprite(textureLink);
                    Iitem item5 = new WoodenBoomerang((Link.posX - 20), Link.posY, 2);
                     
                    item5.appear = true;
                    link.items.Add(item5);
                    break;
                default:
                    break;


            }

        }
      
        public void ChangeToRight()
        {
            link.state = new LinkStandRightNonAttackNonDamageState(link);
        }
        public void ChangeToLeft()
        {
            link.state = new LinkStandLeftNonAttackNonDamageState(link);
        }
        public void ChangeToUp()
        {
            link.state = new LinkStandUpNonAttackNonDamageState(link);
        }
        public void ChangeToDown()
        {
            link.state = new LinkStandDownNonAttackNonDamageState(link);
        }
        public void GetDamaged()
        {
            //cannot attack and damage at the same time
        }
        public void Attack()
        {
            //already attack
        }
        public void ChangeToWalk()
        {
            //cannot walk when attack
        }
        public void ChangeToStand()
        {
            //already stand
        }

        /*public void LinkWithBomb()
        {
            link.state = new LinkDownWithBombState(link);
        }

        public void LinkWithSword()
        {
            link.state = new LinkDownWithSwordState(link);
        }*/
        //what I added
        public void LinkWithItemDown(int itemNum)
        {
            link.state = new LinkWithItemDownState(link, itemNum);
        }
        public void LinkWithItemUp(int itemNum)
        {
            link.state = new LinkWithItemUpState(link, itemNum);
        }
        public void LinkWithItemLeft(int itemNum)
        {
            link.state = new LinkWithItemLeftState(link, itemNum);
        }
        public void LinkWithItemRight(int itemNum)
        {
            link.state = new LinkWithItemRightState(link, itemNum);
        }
        //end
    }
}
