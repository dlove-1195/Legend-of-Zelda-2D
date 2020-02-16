﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class LinkWalkLeftNonAttackNonDamageState: Iplayerstate
    {
        private Link linkPlayer; 
private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        //non damaged, non attack
        public LinkWalkLeftNonAttackNonDamageState(Link link )
        {
            linkPlayer = link;
            linkPlayer = new LinkWalkLeftNonAttackNonDamageSprite(texture);
        }

        public void ChangeToRight()
        {
            linkPlayer.state = new LinkWalkRightNonAttackNonDamageState(linkPlayer);
        }
        public void ChangeToLeft()
        {
            
            // NO-OP
            // already left, do nothing

        }
        public void ChangeToUp()
        {
            linkPlayer.state = new LinkWalkUpNonAttackNonDamageState(linkPlayer);
             

        }
        public void ChangeToDown()
        {

            linkPlayer.state = new LinkWalkDownNonAttackNonDamageState(linkPlayer);
        }
        public void GetDamaged()
        {
            linkPlayer.state = new LinkWalkLeftNonAttackDamageState(linkPlayer);
            

        }
        public void Attack()
        {
            linkPlayer.state = new LinkWalkLeftAttackNonDamageState(linkPlayer);
            

        }

        public void ChangeToWalk()
        {
            //already walk
        }
        public void ChangeToStand()
        {
            linkPlayer.state = new LinkStandLeftNonAttackNonDamageState(linkPlayer);
        }










    }
}
