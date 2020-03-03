﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class LinkWalkRightNonAttackDamageState : Iplayerstate
    {
        private Link linkPlayer;
    private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet2();
        
        public LinkWalkRightNonAttackDamageState(Link link)
        {
            linkPlayer = link;
            linkPlayer.linkSprite = new LinkDamageWalkRightSprite(texture);
            linkPlayer.ChangeX(3);
        }
      

        public void ChangeToRight()
        {

        }
        public void ChangeToLeft()
        {
            if (Link.ifDamage)
            {
                linkPlayer.state = new LinkWalkLeftNonAttackDamageState(linkPlayer);
            }
            else
            {
                linkPlayer.state = new LinkWalkLeftNonAttackNonDamageState(linkPlayer);
            }

        }
        public void ChangeToUp()
        {

            if (Link.ifDamage)
            {
                linkPlayer.state = new LinkWalkUpNonAttackDamageState(linkPlayer);
            }
            else
            {
                linkPlayer.state = new LinkWalkUpNonAttackNonDamageState(linkPlayer);
            }
        }
        public void ChangeToDown()
        {
            if (Link.ifDamage)
            {
                linkPlayer.state = new LinkWalkDownNonAttackDamageState(linkPlayer);
            }
            else
            {
                linkPlayer.state = new LinkWalkDownNonAttackNonDamageState(linkPlayer);
            }


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
            if (!Link.ifDamage)
            {
                linkPlayer.state = new LinkWalkRightNonAttackNonDamageState(linkPlayer);
            }

        }
        public void ChangeToStand()
        {
            if (Link.ifDamage)
            {
                linkPlayer.state = new LinkStandRightNonAttackDamageState(linkPlayer);
            }
            else
            {
                linkPlayer.state = new LinkStandRightNonAttackNonDamageState(linkPlayer);
            }
   
        }

        public void LinkWithItemUp(Iitem item)
        {
            linkPlayer.state = new LinkWithItemDownState(linkPlayer, item);
        }

        public void LinkWithItemDown(Iitem item)
        {
            linkPlayer.state = new LinkWithItemDownState(linkPlayer, item);
        }

        public void LinkWithItemLeft(Iitem item)
        {
            linkPlayer.state = new LinkWithItemLeftState(linkPlayer, item);
        }

        public void LinkWithItemRight(Iitem item)
        {
           // linkPlayer.state = new LinkWithItemRightState(linkPlayer, item);
        }


    }
}
