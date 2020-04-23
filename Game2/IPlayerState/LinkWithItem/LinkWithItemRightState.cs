﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class LinkWithItemRightState : IPlayerstate
    {
        private Link link;
        private Texture2D textureLink = Texture2DStorage.GetLinkSpriteSheet();
        private Texture2D textureLink2 = Texture2DStorage.GetLinkSpriteSheet2();
        // private Texture2D textureItem;
        public LinkWithItemRightState(Link link, int itemNum)
        {
            if (link == null)
            {
                throw new ArgumentNullException(nameof(link));
            }
            this.link = link;
            link.ChangeDirection(3);
             
            switch (itemNum)
            {
                case 0:
                    //arrow
                    link.linkSprite = new LinkStand(textureLink, "Right");
                    IItem item0 = new Arrow((Link.posX + 20), Link.posY+15, 3); 
                     IItem bow= new Bow((Link.posX + 40), Link.posY, 3);
                    link.items.Add(item0);
                    link.items.Add(bow);
                    item0.Appear = true;
                    bow.Appear = true;
                    break;
                case 1:
                    //blue candle
                    link.linkSprite = new LinkStand(textureLink, "Right");
                    IItem item1 = new BlueCandle((Link.posX + 20), Link.posY, 3);
                    link.items.Add(item1);
                    item1.Appear = true;
                    break;
                case 2:
                    //bomb
                    link.linkSprite = new LinkStand(textureLink, "Right");
                    IItem item2 = new Bomb((Link.posX + 20), Link.posY);
                    link.items.Add(item2);
                    item2.Appear = true;
                    break;

                case 3:
                    
                    break;
                case 4:
                    //sword
                    link.linkSprite = new LinkAttack(textureLink,"Right");
                    IItem item4 = new Sword((Link.posX + 20), Link.posY+15, 3);
                    link.items.Add(item4);
                    item4.Appear = true;
                    break;
                case 5:
                    //Boomerang
                    link.linkSprite = new LinkStand(textureLink, "Right");
                    IItem item5 = new WoodenBoomerang((Link.posX + 20), Link.posY, 3);
                    link.items.Add(item5);
                    item5.Appear = true;
                    break;
                case 6:
                    //damage sword
                    IItem damageSword = new DamageSword(Link.posX + 20, (Link.posY + 15), 3);
                    damageSword.Appear = true;
                    Link.oldDamageState = true;
                    link.linkSprite = new LinkDamageAttack(textureLink2,"Right");
                    link.items.Add(damageSword);
                    break;
                case 7:
                    //damge arrow
                    IItem Damagearrow = new DamageArrow(Link.posX + 20, (Link.posY + 15), 3);
                    IItem Damagebow = new DamageBow((Link.posX+40), (Link.posY), 3);
                    Damagearrow.Appear = true;
                    Damagebow.Appear = true;
                    Link.oldDamageState = true;
                    link.items.Add(Damagearrow);
                    link.items.Add(Damagebow);
                    link.linkSprite = new LinkDamageStand(textureLink2, "Right");
                    break;
                case 8:
                    //damage candle fire
                    IItem Damagecandle = new DamageFire((Link.posX+20), (Link.posY), 3);
                    Damagecandle.Appear = true;
                    Link.oldDamageState = true;
                    link.items.Add(Damagecandle);
                    link.linkSprite = new LinkDamageStand(textureLink2, "Right");
                    break;
                case 9:
                    //damage bomb
                    IItem Damagebomb = new DamageBomb((Link.posX+20), (Link.posY));
                    Damagebomb.Appear = true;
<<<<<<< HEAD
                    link.linkSprite = new LinkDamageStand(textureLink2, "Right");
=======
                    Link.oldDamageState = true;
                    link.linkSprite = new LinkDamageStandRightSprite(textureLink2);
>>>>>>> 4a09fe5dc504b09f6ef8e68dca13a018cf576f1b

                    link.items.Add(Damagebomb);
                    break;
                case 10:
                    //damage boomrang
                    IItem Damageboomerang = new DamageWoodenBoomerang((Link.posX+20), (Link.posY), 3);
                    Damageboomerang.Appear = true;
<<<<<<< HEAD
                    link.linkSprite = new LinkDamageStand(textureLink2, "Right");
=======
                    Link.oldDamageState = true;
                    link.linkSprite = new LinkDamageStandRightSprite(textureLink2);
>>>>>>> 4a09fe5dc504b09f6ef8e68dca13a018cf576f1b
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
            if (!Link.ifDamage && Link.oldDamageState)
            {
                link.state = new LinkStandRightNonAttackNonDamageState(link);
                Link.oldDamageState = false;
            }
            else
            {
                link.state = new LinkStandRightNonAttackDamageState(link);
            }
        }
        public void ChangeToLeft()
        {
            if (!Link.ifDamage && Link.oldDamageState)
            {
                link.state = new LinkStandLeftNonAttackNonDamageState(link);
                Link.oldDamageState = false;
            }
            else
            {
                link.state = new LinkStandLeftNonAttackDamageState(link);
            }
        }
        public void ChangeToUp()
        {
            if (!Link.ifDamage && Link.oldDamageState)
            {
                link.state = new LinkStandUpNonAttackNonDamageState(link);
                Link.oldDamageState = false;
            }
            else
            {
                link.state = new LinkStandUpNonAttackDamageState(link);
            }
        }
        public void ChangeToDown()
        {
            if (!Link.ifDamage && Link.oldDamageState)
            {
                link.state = new LinkStandDownNonAttackNonDamageState(link);
                Link.oldDamageState = false;
            }
            else
            {
                link.state = new LinkStandDownNonAttackDamageState(link);
            }
        }
        public void GetDamaged()
        {
            link.state = new LinkStandRightNonAttackDamageState(link);
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
                link.state = new LinkStandRightNonAttackNonDamageState(link);
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
        public void LinkWithItemDown(int item)
        {
            link.state = new LinkWithItemDownState(link, item);
        }
        public void LinkWithItemUp( int item)
        {
            link.state = new LinkWithItemUpState(link, item);
        }
        public void LinkWithItemLeft( int item)
        {
            link.state = new LinkWithItemLeftState(link, item);
        }
        public void LinkWithItemRight( int item)
        {
            link.state = new LinkWithItemRightState(link, item);
        }
        //end
    }
}