using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class LinkWithItemDownState : Iplayerstate
    {
        private Link link;
        private Texture2D textureLink = Texture2DStorage.GetLinkSpriteSheet();
       // private Texture2D textureItem;
        public LinkWithItemDownState(Link link,  int itemNum)
        {

            this.link = link;
            link.ChangeDirection(1);
         
            switch (itemNum)
                    {
                case 0:
                    //arrow
                     Iitem arrow = new Arrow(Link.posX, (Link.posY + 20), 1);
                    Iitem bow = new Bow(Link.posX, (Link.posY + 20), 1);
                    arrow.appear = true;
                    bow.appear = true;
                    link.items.Add(arrow);
                    link.items.Add(bow);
                    link.linkSprite = new LinkStandDownSprite(textureLink);
                    
                    
                    break;
                case 1:
                    //blue candle
                    Iitem candle = new BlueCandle(Link.posX, (Link.posY + 20), 1);
                    candle.appear = true;
                    link.items.Add(candle);
                    link.linkSprite = new LinkStandDownSprite(textureLink);
                    
                    break;
                case 2:
                    //bomb
                    Iitem bomb = new Bomb(Link.posX, (Link.posY + 20));
                    bomb.appear = true;
                    link.linkSprite = new LinkStandDownSprite(textureLink);

                    link.items.Add(bomb);
                    
                    break;
 
                case 4:
                    //sword
                    Iitem sword = new Sword(Link.posX+16, (Link.posY + 20), 1);
                    sword.appear = true;
                    link.linkSprite = new LinkAttackDownSprite(textureLink);
                    link.items.Add(sword); 
                    break;
                case 5:
                    //Boomerang
                    Iitem boomerang = new WoodenBoomerang(Link.posX, (Link.posY + 20), 1);
                    boomerang.appear = true;
                    link.linkSprite = new LinkStandDownSprite(textureLink);
                    link.items.Add(boomerang);
                   
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

        
        public void LinkWithItemDown(int item)
        {
            link.state = new LinkWithItemDownState(link, item);
        }
        public void LinkWithItemUp(int item) {
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
