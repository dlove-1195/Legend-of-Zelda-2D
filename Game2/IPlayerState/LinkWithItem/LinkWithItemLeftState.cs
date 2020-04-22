﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class LinkWithItemLeftState : IPlayerstate
    {
       
        private Link link;
        private Texture2D textureLink = Texture2DStorage.GetLinkSpriteSheet();

        private Texture2D textureLink2 = Texture2DStorage.GetLinkSpriteSheet2();
        public LinkWithItemLeftState(Link link, int itemNum)
        {
            if (link == null)
            {
                throw new ArgumentNullException(nameof(link));
            }
            this.link = link;
            link.ChangeDirection(2);
            
            switch (itemNum )
            {
                case 0:
                    //arrow
                    link.linkSprite = new LinkStandLeftSprite(textureLink);
                     IItem item0 = new Arrow((Link.posX - 20), Link.posY+15, 2);
                    IItem bow = new Bow((Link.posX - 20), Link.posY, 2);
                    item0.Appear = true;
                    bow.Appear =true;
                    link.items.Add(item0);
                    link.items.Add(bow);
                    break;
                case 1:
                    //blue candle
                    link.linkSprite = new LinkStandLeftSprite(textureLink);
                    IItem item1 = new BlueCandle((Link.posX - 20), Link.posY, 2);
                    item1.Appear = true;
                    link.items.Add(item1);
                    break;
                case 2:
                    //bomb
                    link.linkSprite = new LinkStandLeftSprite(textureLink);
                    IItem item2 = new Bomb((Link.posX - 20), Link.posY);
                   
                    item2.Appear = true;
                    link.items.Add(item2);
                    break;

                case 3:
                   
                    break;
                case 4:
                    //sword
                    link.linkSprite = new LinkAttackLeftSprite(textureLink);
                    IItem item4 = new Sword((Link.posX - 20), Link.posY +17, 2);
                   
                    item4.Appear = true;
                    link.items.Add(item4);
                    break;
                case 5:
                    //Boomerang
                    link.linkSprite = new LinkStandLeftSprite(textureLink);
                    IItem item5 = new WoodenBoomerang((Link.posX - 20), Link.posY, 2);
                     
                    item5.Appear = true;
                    link.items.Add(item5);
                    break;
                case 6:
                    //damage sword
                    IItem damageSword = new DamageSword(Link.posX - 20, (Link.posY + 17), 2);
                    damageSword.Appear = true;
                    Link.oldDamageState = true;
                    link.linkSprite = new LinkDamageAttackLeftSprite(textureLink2);
                    link.items.Add(damageSword);
                    break;
                case 7:
                    //damge arrow
                    IItem Damagearrow = new DamageArrow(Link.posX - 20, (Link.posY + 15), 2);
                    IItem Damagebow = new DamageBow((Link.posX-20), (Link.posY), 2);
                    Damagearrow.Appear = true;
                    Damagebow.Appear = true;
                    link.items.Add(Damagearrow);
                    link.items.Add(Damagebow);
                    link.linkSprite = new LinkDamageStandLeftSprite(textureLink2);
                    break;
                case 8:
                    //damage candle fire
                    IItem Damagecandle = new BlueCandle((Link.posX-20), (Link.posY), 2);
                    Damagecandle.Appear = true;
                    link.items.Add(Damagecandle);
                    link.linkSprite = new LinkDamageStandLeftSprite(textureLink2);
                    break;
                case 9:
                    //damage bomb
                    IItem Damagebomb = new DamageBomb((Link.posX-20), (Link.posY));
                    Damagebomb.Appear = true;
                    link.linkSprite = new LinkDamageStandLeftSprite(textureLink2);

                    link.items.Add(Damagebomb);
                    break;
                case 10:
                    //damage boomrang
                    IItem Damageboomerang = new DamageWoodenBoomerang((Link.posX-20), (Link.posY), 2);
                    Damageboomerang.Appear = true;
                    link.linkSprite = new LinkDamageStandLeftSprite(textureLink2);
                    link.items.Add(Damageboomerang);
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
            link.state = new LinkStandLeftNonAttackDamageState(link);
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
            if (!Link.ifDamage && Link.oldDamageState)
            {
                link.state = new LinkStandLeftNonAttackNonDamageState(link);
                Link.oldDamageState = false;
            }
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
