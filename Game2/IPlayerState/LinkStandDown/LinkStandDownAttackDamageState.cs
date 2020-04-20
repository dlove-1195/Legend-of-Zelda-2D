﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Sprint2 
{
    public class LinkStandDownAttackDamageState: IPlayerstate
    {
        private Link link;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet2();
        public LinkStandDownAttackDamageState(Link link)
        {
            if (link == null)
            {
                throw new ArgumentNullException(nameof(link));
            }
            link.linkSprite = new LinkDamageAttackDownSprite(texture);
            this.link = link;
            Link.ifDamage = true;
             
            this.link.ChangeDirection(1);

            link.simpleAttackBox = new Rectangle(Link.posX + 10, Link.posY + 45, 25, 45);

        }
        public void Win()
        {
            link.state = new LinkWinningState(link);

        }
        public void ChangeToRight()
        {
            if (Link.ifDamage)
            {
                link.state = new LinkStandRightNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkStandRightNonAttackNonDamageState(link);
            }
        }
        public void ChangeToLeft()
        {
            if (Link.ifDamage)
            {
                link.state = new LinkStandLeftNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkStandLeftNonAttackNonDamageState(link);
            }
        }
        public void ChangeToUp()
        {
            if (Link.ifDamage)
            {
                link.state = new LinkStandUpNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkStandUpNonAttackNonDamageState(link);
            }
        }
        public void ChangeToDown()
        {
            if (Link.ifDamage)
            {
                link.state = new LinkStandDownNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkStandDownNonAttackNonDamageState(link);
            }
        }
     
        public void GetDamaged()
        {
            link.state = new LinkStandDownNonAttackDamageState(link);
        }
        public void Attack()
        {
            if (Link.ifDamage)
            {
                link.state = new LinkStandDownAttackDamageState(link);
            }
            
        }
        public void ChangeToWalk()
        {
            link.state = new LinkWalkDownNonAttackDamageState(link);
            /*if (Link.ifDamage)
            {
                link.state = new LinkWalkDownNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkWalkDownNonAttackNonDamageState(link);
            }*/
        }
        public void ChangeToStand()
        {
            if(!Link.ifDamage)
            {
                link.state = new LinkStandDownNonAttackNonDamageState(link);
            }
        }

        public void LinkWithItemUp(int item)
        {
           link.state = new LinkWithItemUpState(link, item);
        }

        public void LinkWithItemDown(int item)
        {
            link.state = new LinkWithItemDownState(link, item);
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

