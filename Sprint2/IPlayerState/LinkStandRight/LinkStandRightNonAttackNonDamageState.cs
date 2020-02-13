﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2 
{
    class LinkStandRightNonAttackNonDamageState: Iplayerstate
    {
        private Link link;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        public LinkStandRightNonAttackNonDamageState(Link link)
        {
            
            this.link = link;
            link.linkSprite = new LinkStandRightSprite(texture);
        }
        public void ChangeToRight()
        {
            //already right
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
      
        public void ChangeToWalk()
        {
            link.state = new LinkWalkRightNonAttackNonDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }
    }
}