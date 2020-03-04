﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Sprint2 
{
    public class LinkStandLeftNonAttackNonDamageState: Iplayerstate
    {
        private Link link;
         
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet() ; 
        public LinkStandLeftNonAttackNonDamageState(Link link)
        {
            this.link = link;
            link.linkSprite = new LinkStandLeftSprite(texture);
            this.link.ChangeDirection(2);

        }
        
        public void ChangeToRight()
        {
            link.state = new LinkStandRightNonAttackNonDamageState(link);
        }
        public void ChangeToLeft()
        {
            //already left
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
            Link.ifDamage = true;
        }
        public void Attack()
        {
            link.state = new LinkStandLeftAttackNonDamageState(link);
        }
        public void ChangeToWalk()
        {
            link.state = new LinkWalkLeftNonAttackNonDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
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