﻿using Microsoft.Xna.Framework.Graphics;
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
                     Iitem item0= new Arrow(Link.posX, (Link.posY - 20),0);
                     Iitem bow = new Bow(Link.posX, (Link.posY - 20), 0);
                    item0.appear = true;
                    bow.appear = true;
                    link.items.Add(item0);
                    link.items.Add(bow);

                    break;
                case 1:
                    //blue candle
                    link.linkSprite = new LinkStandUpSprite(textureLink);
                    Iitem item1 = new BlueCandle(Link.posX, (Link.posY - 20),0);
                    item1.appear = true;
                    link.items.Add(item1);

                    break;
                case 2:
                    //bomb
                    link.linkSprite = new LinkStandUpSprite(textureLink);
                    Iitem item2 = new Bomb(Link.posX, (Link.posY - 20));
                    item2.appear = true;
                    link.items.Add(item2);
                    break;

                case 3:
                    
                    break;
                case 4:
                    //sword
                    link.linkSprite = new LinkAttackUpSprite(textureLink);
                    Iitem item4 = new Sword(Link.posX+7, (Link.posY - 20), 0);
                    item4.appear = true;
                    link.items.Add(item4);
                    break;
                case 5:
                    //Boomerang
                    link.linkSprite = new LinkStandUpSprite(textureLink);
                    Iitem item5 = new WoodenBoomerang(Link.posX, (Link.posY - 20), 0);
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