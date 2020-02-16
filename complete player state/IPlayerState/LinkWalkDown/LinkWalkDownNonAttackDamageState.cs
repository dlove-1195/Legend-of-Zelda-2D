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

        
        public LinkWalkDownNonAttackDamageState(Link link)
        {
            linkPlayer = link;
            linkPlayer = new LinkWalkDownNonAttackDamageSprite(texture);
        }

        public void ChangeToRight()
        {
            linkPlayer.state = new LinkWalkRightNonAttackDamageState(linkPlayer);
            
        }
        public void ChangeToLeft()
        {
            linkPlayer.state = new LinkWalkLeftNonAttackDamageState(linkPlayer);
            

        }
        public void ChangeToUp()
        {
            linkPlayer.state = new LinkWalkUpNonAttackDamageState(linkPlayer);

        }
        public void ChangeToDown()
        {
            // NO-OP
            // already Down, do nothing


        }
        public void GetDamaged()
        {
            // NO-OP
            // already damage, do nothing

        }
        public void Attack()
        {
            linkPlayer.state = new LinkWalkDownAttackDamgeState(linkPlayer);
             
        }

        public void ChangeToWalk()
        {
            //already walk
        }
        public void ChangeToStand()
        {
            linkPlayer.state = new LinkStandDownNonAttackDamageState(linkPlayer);
        }


    }
}
