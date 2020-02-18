using Microsoft.Xna.Framework.Graphics;
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

        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet2();
        public LinkWalkLeftNonAttackDamageState(Link link)
        {
            linkPlayer = link;
            linkPlayer.linkSprite = new LinkDamageWalkLeftSprite(texture);
        }

        public void ChangeToRight()
        {
            if (Link.ifDamage)
            {
                linkPlayer.state = new LinkWalkRightNonAttackDamageState(linkPlayer);
            }
            else
            {
                linkPlayer.state = new LinkWalkRightNonAttackNonDamageState(linkPlayer);
            }

        }
        public void ChangeToLeft()
        {
            


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
                  linkPlayer.state = new LinkWalkLeftNonAttackNonDamageState(linkPlayer);
              }

        }
        public void ChangeToStand()
        {
            if (Link.ifDamage)
            {
                linkPlayer.state = new LinkStandLeftNonAttackDamageState(linkPlayer);
            }
            else
            {
                linkPlayer.state = new LinkStandLeftNonAttackNonDamageState(linkPlayer);
            }
        }

        public void LinkWithBomb()
        {

        }

        public void LinkWithSword()
        {

        }

    }
}
