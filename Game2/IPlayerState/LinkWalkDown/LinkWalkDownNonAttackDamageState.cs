using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class LinkWalkDownNonAttackDamageState : Iplayerstate
    {
        private Link linkPlayer;
    private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet2();
        
        public LinkWalkDownNonAttackDamageState(Link link)
        {
            linkPlayer = link;
            linkPlayer.linkSprite = new LinkDamageWalkDownSprite(texture);
            linkPlayer.ChangeX(1);

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
           


        }
        public void GetDamaged()
        {

        }
        public void Attack()
        {
            
             
        }

        public void ChangeToWalk()
        {
           if (!Link.ifDamage)
            {
                linkPlayer.state = new LinkWalkDownNonAttackNonDamageState(linkPlayer);
            }
        }
        public void ChangeToStand()
        {
    
            
            if (Link.ifDamage)
            {
                linkPlayer.state = new LinkStandDownNonAttackDamageState(linkPlayer);
            }
            else
            {
                linkPlayer.state = new LinkStandDownNonAttackNonDamageState(linkPlayer);
            } 
        }

        public void LinkWithItemUp(Iitem item)
        {
            linkPlayer.state = new LinkWithItemDownState(linkPlayer, item);
        }

        public void LinkWithItemDown(Iitem item)
        {
            //do nothing
        }

        public void LinkWithItemLeft(Iitem item)
        {
            linkPlayer.state = new LinkWithItemLeftState(linkPlayer, item);
        }

        public void LinkWithItemRight(Iitem item)
        {
            linkPlayer.state = new LinkWithItemRightState(linkPlayer, item);
        }


    }
}
