﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Sprint2 
{
    public class LinkStandUpNonAttackDamageState: Iplayerstate
    {
        private Link link;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet2();
        public LinkStandUpNonAttackDamageState(Link link)
        {
            link.linkSprite = new LinkDamageStandUpSprite(texture);
            this.link = link;
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
            link.state = new LinkStandUpNonAttackDamageState(link);
        }
        public void Attack()
        {
            
        }
        public void ChangeToWalk()
        {
            if (Link.ifDamage)
            {
                link.state = new LinkWalkUpNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkWalkUpNonAttackNonDamageState(link);
            }
        }
        public void ChangeToStand()
        {
            if (!Link.ifDamage)
            {
                link.state = new LinkStandUpNonAttackNonDamageState(link);
            }
        }

        public void LinkWithBomb()
        {
            link.state = new LinkUpWithBombState(link);
        }

        public void LinkWithSword()
        {
            link.state = new LinkUpWithSwordState(link);
        }
    }
}
