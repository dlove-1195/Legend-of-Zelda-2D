using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class LinkWithItemDownState : IPlayerstate
    {
        private Link link;
        private Texture2D textureLink = Texture2DStorage.GetLinkSpriteSheet();

        private Texture2D textureLink2 = Texture2DStorage.GetLinkSpriteSheet2();
        // private Texture2D textureItem;
        public LinkWithItemDownState(Link link, int itemNum)
        {
            if (link == null)
            {
                throw new ArgumentNullException(nameof(link));
            }
            this.link = link;
            link.ChangeDirection(1);

            switch (itemNum)
            {
                case 0:
                    //arrow
                    IItem arrow = new Arrow(Link.posX + 15, (Link.posY + 20), 1);
                    IItem bow = new Bow(Link.posX, (Link.posY + 40), 1);
                    arrow.Appear = true;
                    bow.Appear = true;
                    link.items.Add(arrow);
                    link.items.Add(bow);
                    link.linkSprite = new LinkStand(textureLink,"Down");


                    break;
                case 1:
                    //blue candle
                    IItem candle = new BlueCandle(Link.posX, (Link.posY + 20), 1);
                    candle.Appear = true;
                    link.items.Add(candle);
                    link.linkSprite = new LinkStand(textureLink, "Down");

                    break;
                case 2:
                    //bomb
                    IItem bomb = new Bomb(Link.posX, (Link.posY + 20));
                    bomb.Appear = true;
                    link.linkSprite = new LinkStand(textureLink, "Down");

                    link.items.Add(bomb);

                    break;

                case 4:
                    //sword
                    IItem sword = new Sword(Link.posX + 16, (Link.posY + 20), 1);
                    sword.Appear = true;
                    link.linkSprite = new LinkAttack(textureLink, "Down");
                    link.items.Add(sword);
                    break;
                case 5:
                    //Boomerang
                    IItem boomerang = new WoodenBoomerang(Link.posX, (Link.posY + 20), 1);
                    boomerang.Appear = true;
                    link.linkSprite = new LinkStand(textureLink,"Down");
                    link.items.Add(boomerang);
                    break;
                case 6:
                    //damage sword
                    IItem damageSword = new DamageSword(Link.posX + 16, (Link.posY + 20), 1);
                    damageSword.Appear = true;
                    Link.oldDamageState = true;
                    link.linkSprite = new LinkDamageAttack(textureLink2,"Down");
                    link.items.Add(damageSword);
                    break;
                case 7:
                    //damge arrow
                    IItem Damagearrow = new DamageArrow(Link.posX + 15, (Link.posY + 20), 1);
                    IItem Damagebow = new DamageBow(Link.posX, (Link.posY + 40), 1);
                    Damagearrow.Appear = true;
                    Damagebow.Appear = true;
                    Link.oldDamageState = true;
                    link.items.Add(Damagearrow);
                    link.items.Add(Damagebow);
                    link.linkSprite = new LinkDamageStand(textureLink2,"Down");
                    break;
                case 8:
                    //damage candle fire
                    IItem Damagecandle = new DamageFire(Link.posX, (Link.posY + 20), 1);
                    Damagecandle.Appear = true;
                    Link.oldDamageState = true;
                    link.items.Add(Damagecandle);
                    link.linkSprite = new LinkDamageStand(textureLink2, "Down");
                    break;
                case 9:
                    //damage bomb
                    IItem Damagebomb = new DamageBomb(Link.posX, (Link.posY + 20));
                    Damagebomb.Appear = true;
                    Link.oldDamageState = true;

                    link.linkSprite = new LinkDamageStand(textureLink2, "Down");


                    link.items.Add(Damagebomb);
                    break;
                case 10:
                    //damage boomrang
                    IItem Damageboomerang = new DamageWoodenBoomerang(Link.posX, (Link.posY + 20), 1);
                    Damageboomerang.Appear = true;
                    Link.oldDamageState = true;

                    link.linkSprite = new LinkDamageStand(textureLink2, "Down");

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
            if (!Link.ifDamage )
            {
                link.state = new LinkStandRightNonAttackNonDamageState(link);
            
            }
            else
            {
                link.state = new LinkStandRightNonAttackDamageState(link);
            }
        }
        public void ChangeToLeft()
        {
            if (!Link.ifDamage )
            {
                link.state = new LinkStandLeftNonAttackNonDamageState(link);
            
            }
            else
            {
                link.state = new LinkStandLeftNonAttackDamageState(link);
            }
        }
        public void ChangeToUp()
        {
            if (!Link.ifDamage)
            {
                link.state = new LinkStandUpNonAttackNonDamageState(link);
         
            }
            else
            {
                link.state = new LinkStandUpNonAttackDamageState(link);
            }
        }
        public void ChangeToDown()
        {
            if (!Link.ifDamage )
            {
                link.state = new LinkStandDownNonAttackNonDamageState(link);
            
            }
            else
            {
                link.state = new LinkStandDownNonAttackDamageState(link);
            }
        }
        public void GetDamaged()
        {
            if (!Link.ifDamage && Link.oldDamageState)
            {
                link.state = new LinkStandDownNonAttackDamageState(link);
            }
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
                link.state = new LinkStandDownNonAttackNonDamageState(link);
                Link.oldDamageState = false;
            }

        }

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

    }
}
