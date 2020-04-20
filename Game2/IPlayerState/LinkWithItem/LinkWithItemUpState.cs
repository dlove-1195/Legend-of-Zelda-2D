using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class LinkWithItemUpState : IPlayerstate
    {
        private Link link;
        private Texture2D textureLink = Texture2DStorage.GetLinkSpriteSheet();
        private Texture2D textureLink2 = Texture2DStorage.GetLinkSpriteSheet2();
        public LinkWithItemUpState(Link link, int itemNum)
        {
            if (link == null)
            {
                throw new ArgumentNullException(nameof(link));
            }
            this.link = link;
            link.ChangeDirection(0);
        
            switch (itemNum)
            {
                case 0:
                    //arrow
                    link.linkSprite = new LinkStandUpSprite(textureLink);
                     IItem item0= new Arrow(Link.posX+12, (Link.posY - 20),0);
                     IItem bow = new Bow(Link.posX-4, (Link.posY - 25), 0);
                    item0.Appear = true;
                    bow.Appear = true;
                    link.items.Add(item0);
                    link.items.Add(bow);

                    break;
                case 1:
                    //blue candle
                    link.linkSprite = new LinkStandUpSprite(textureLink);
                    IItem item1 = new BlueCandle(Link.posX, (Link.posY - 20),0);
                    item1.Appear = true;
                    link.items.Add(item1);

                    break;
                case 2:
                    //bomb
                    link.linkSprite = new LinkStandUpSprite(textureLink);
                    IItem item2 = new Bomb(Link.posX, (Link.posY - 20));
                    item2.Appear = true;
                    link.items.Add(item2);
                    break;

                case 3:
                    
                    break;
                case 4:
                    //sword
                    link.linkSprite = new LinkAttackUpSprite(textureLink);
                    IItem item4 = new Sword(Link.posX+7, (Link.posY - 20), 0);
                    item4.Appear = true;
                    link.items.Add(item4);
                    break;
                case 5:
                    //Boomerang
                    link.linkSprite = new LinkStandUpSprite(textureLink);
                    IItem item5 = new WoodenBoomerang(Link.posX, (Link.posY - 20), 0);
                    item5.Appear = true;
                    link.items.Add(item5);
                    break;
                case 6:
                    //damage sword
                    IItem damageSword = new DamageSword(Link.posX + 7, (Link.posY - 20), 0);
                    damageSword.Appear = true;
                    link.linkSprite = new LinkDamageAttackUpSprite(textureLink2);
                    link.items.Add(damageSword);
                    break;
                default:
                    break;


            }


        }
        public void Win()
        {
            link.state = new LinkWinningState(link);
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
            link.state = new LinkStandUpNonAttackDamageState(link);
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