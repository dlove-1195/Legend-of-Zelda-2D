﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class LinkWalkUpNonAttackNonDamageState: Iplayerstate
    {
        private Link linkPlayer; 
private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        //non damaged, non attack
        public LinkWalkUpNonAttackNonDamageState(Link link )
        {
            linkPlayer = link;
            linkPlayer.linkSprite = new LinkWalkUpSprite(texture);
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
            // NO-OP
            // already up, do nothing

        }
        public void ChangeToDown()
        {
            linkPlayer.state = new LinkWalkDownNonAttackNonDamageState(linkPlayer);
             

        }
        public void GetDamaged()
        {
            Link.ifDamage = true;
            linkPlayer.state = new LinkWalkUpNonAttackDamageState(linkPlayer);
            

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
            linkPlayer.state = new LinkStandUpNonAttackNonDamageState(linkPlayer);
        }

        public void LinkWithBomb()
        {

        }

        public void LinkWithSword()
        {

        }







    }
}
