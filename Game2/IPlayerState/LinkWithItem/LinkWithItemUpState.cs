using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class LinkWithItemUpState : Iplayerstate
    {
        private Link link;
        private Texture2D textureLink = Texture2DStorage.GetLinkSpriteSheet();
        public LinkWithItemUpState(Link link, int itemNum)
        {

            this.link = link;
            link.ChangeDirection(0);
        
            switch (itemNum)
            {
                case 0:
                    //arrow
                    link.linkSprite = new LinkStandUpSprite(textureLink);
                    link.arrow = new Arrow(Link.posX, (Link.posY - 20),0);
                    Arrow.bow = new Bow(Link.posX, (Link.posY - 20), 0);
                    Link.linkWithItem[2] = true;

                    break;
                case 1:
                    //blue candle
                    link.linkSprite = new LinkStandUpSprite(textureLink);
                    link.bluecandle = new BlueCandle(Link.posX, (Link.posY - 20),0);
                    Link.linkWithItem[4] = true;

                    break;
                case 2:
                    //bomb
                    link.linkSprite = new LinkStandUpSprite(textureLink);
                    link.bomb = new Bomb(Link.posX, (Link.posY - 20));
                    Link.linkWithItem[0] = true;
                    break;

                case 3:
                    
                    break;
                case 4:
                    //sword
                    link.linkSprite = new LinkAttackUpSprite(textureLink);
                    link.sword = new Sword(Link.posX, (Link.posY - 20), 0);
                    Link.linkWithItem[1] = true;
                    break;
                case 5:
                    //Boomerang
                    link.linkSprite = new LinkStandUpSprite(textureLink);
                    link.boomerang = new WoodenBoomerang(Link.posX, (Link.posY - 20), 0);
                    Link.linkWithItem[3] = true;
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

        
        //what I added
        public void LinkWithItemDown(int item)
        {
            link.state = new LinkWithItemDownState(link, item);
        }
        public void LinkWithItemUp(int item)
        {
            link.state = new LinkWithItemUpState(link, item);
        }
        public void LinkWithItemLeft(int item)
        {
            link.state = new LinkWithItemLeftState(link, item);
        }
        public void LinkWithItemRight(int item)
        {
            link.state = new LinkWithItemRightState(link, item);
        }
        //end
    }
}