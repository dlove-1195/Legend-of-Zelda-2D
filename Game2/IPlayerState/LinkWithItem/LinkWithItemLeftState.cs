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
                    link.linkSprite = new LinkAttackLeftSprite(textureLink);
                    link.arrow = new Arrow((Link.posX - 20), Link.posY, 2);
                    if (!Link.linkDropItem)
                        link.arrow = null;
                    break;
                case 1:
                    //blue candle
                    link.linkSprite = new LinkStandLeftSprite(textureLink);
                    link.bluecandle = new BlueCandle((Link.posX - 20), Link.posY, 2);
                    if (!Link.linkDropItem)
                        link.bluecandle = null;
                    break;
                case 2:
                    //bomb
                    link.linkSprite = new LinkStandLeftSprite(textureLink);
                    link.bomb = new Bomb((Link.posX - 20), Link.posY);
                    if (!Link.linkDropItem)
                        link.bomb = null;
                    break;

                case 3:
                    //bow
                    Console.WriteLine("bow change to left");
                    link.linkSprite = new LinkAttackLeftSprite(textureLink);
                    link.bow = new Bow((Link.posX - 20), Link.posY, 2);
                    if (!Link.linkDropItem)
                        link.bow = null;
                    break;
                case 4:
                    //sword
                    link.linkSprite = new LinkAttackLeftSprite(textureLink);
                    link.sword = new Sword((Link.posX - 20), Link.posY, 2);
                    if (!Link.linkDropItem)
                        link.sword = null;
                    break;
                case 5:
                    //Boomerang
                    link.linkSprite = new LinkAttackLeftSprite(textureLink);
                    link.boomerang = new WoodenBoomerang((Link.posX - 20), Link.posY, 2);
                    if (!Link.linkDropItem)
                        link.boomerang = null;
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
