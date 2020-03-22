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
       // private Texture2D textureItem;
        public LinkWithItemDownState(Link link,  int itemNum)
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
                     IItem arrow = new Arrow(Link.posX, (Link.posY + 20), 1);
                    IItem bow = new Bow(Link.posX, (Link.posY + 20), 1);
                    arrow.Appear = true;
                    bow.Appear = true;
                    link.items.Add(arrow);
                    link.items.Add(bow);
                    link.linkSprite = new LinkStandDownSprite(textureLink);
                    
                    
                    break;
                case 1:
                    //blue candle
                    IItem candle = new BlueCandle(Link.posX, (Link.posY + 20), 1);
                    candle.Appear = true;
                    link.items.Add(candle);
                    link.linkSprite = new LinkStandDownSprite(textureLink);
                    
                    break;
                case 2:
                    //bomb
                    IItem bomb = new Bomb(Link.posX, (Link.posY + 20));
                    bomb.Appear = true;
                    link.linkSprite = new LinkStandDownSprite(textureLink);

                    link.items.Add(bomb);
                    
                    break;
 
                case 4:
                    //sword
                    IItem sword = new Sword(Link.posX+16, (Link.posY + 20), 1);
                    sword.Appear = true;
                    link.linkSprite = new LinkAttackDownSprite(textureLink);
                    link.items.Add(sword); 
                    break;
                case 5:
                    //Boomerang
                    IItem boomerang = new WoodenBoomerang(Link.posX, (Link.posY + 20), 1);
                    boomerang.Appear = true;
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
