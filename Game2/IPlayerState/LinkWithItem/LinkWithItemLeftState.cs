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
        public LinkWithItemLeftState(Link link, Iitem item)
        {

            this.link = link;
            link.ChangeX(2);
            switch (item.getItem())
            {
                case 0:
                    //arrow
                    link.linkSprite = new LinkAttackLeftSprite(textureLink);
                    link.arrow = new Arrow((Link.posX-20), Link.posY, 2);
                    break;
                case 1:
                    //blue candle
                    link.linkSprite = new LinkStandLeftSprite(textureLink);
                    link.bluecandle = new BlueCandle((Link.posX - 20), Link.posY, 2);
                    break;
                case 2:
                    //bomb
                    link.linkSprite = new LinkStandLeftSprite(textureLink);
                    link.bomb = new Bomb((Link.posX - 20), Link.posY);
                    break;

                case 3:
                    //bow
                    link.linkSprite = new LinkAttackLeftSprite(textureLink);
                    link.bow = new Bow((Link.posX - 20), Link.posY, 2);
                    break;
                case 4:
                    //sword
                    link.linkSprite = new LinkAttackLeftSprite(textureLink);
                    link.sword = new Sword((Link.posX - 20), Link.posY, 2);
                    break;
                case 5:
                    //Boomerang
                    link.linkSprite = new LinkAttackLeftSprite(textureLink);
                    link.boomerang = new WoodenBoomerang((Link.posX - 20), Link.posY, 2);
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
        public void LinkWithItemDown(Iitem item)
        {
            link.state = new LinkWithItemDownState(link, item);
        }
        public void LinkWithItemUp(Iitem item)
        {
            link.state = new LinkWithItemUpState(link, item);
        }
        public void LinkWithItemLeft(Iitem item)
        {
            link.state = new LinkWithItemLeftState(link, item);
        }
        public void LinkWithItemRight(Iitem item)
        {
            link.state = new LinkWithItemRightState(link, item);
        }
        //end
    }
}
