﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class LinkWalkLeftNonAttackDamageState : Iplayerstate
    {
        private Link linkPlayer;

        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        public LinkWalkLeftNonAttackDamageState(Link link)
        {
            linkPlayer = link;
            linkPlayer.linkSprite = new LinkDamageWalkLeftSprite(texture);
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
            linkPlayer.state = new LinkWalkDownNonAttackNonDamageState(linkPlayer);


        }
        public void GetDamaged()
        {
            // NO-OP
            // already damage, do nothing

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
            linkPlayer.state = new LinkStandLeftNonAttackNonDamageState(linkPlayer);
        }

        public void LinkWithBomb()
        {

        }

        public void LinkWithSword()
        {

        }

    }
}
