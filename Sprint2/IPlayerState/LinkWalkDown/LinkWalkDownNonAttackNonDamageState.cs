﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Sprint2
{
    class LinkWalkDownNonAttackNonDamageState: Iplayerstate
    {
        private Link linkPlayer;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        //non damaged, non attack
        public LinkWalkDownNonAttackNonDamageState(Link link )
        {
            linkPlayer = link;
            link.linkSprite = new LinkWalkDownSprite(texture);
        }

        public void ChangeToRight()
        {
            linkPlayer.state = new LinkWalkRightNonAttackNonDamageState(linkPlayer);
            
        }
        public void ChangeToLeft()
        {
            linkPlayer.state = new LinkWalkLeftNonAttackNonDamageState(linkPlayer);
             

        }
        public void ChangeToUp()
        {
            linkPlayer.state = new LinkWalkUpNonAttackNonDamageState(linkPlayer);
             

        }
        public void ChangeToDown()
        {
            // NO-OP
            // already down, do nothing

        }
        public void GetDamaged()
        {
            linkPlayer.state = new LinkWalkDownNonAttackDamageState(linkPlayer);
            

        }
        public void Attack()
        {
            
            

        }

        public void ChangeToWalk()
        {
            //already walk
        }
        public void ChangeToStand()
        {
            linkPlayer.state = new LinkStandDownNonAttackNonDamageState(linkPlayer);
        }

        public void LinkWithBomb()
        {

        }

        public void LinkWithSword()
        {

        }












    }
}
