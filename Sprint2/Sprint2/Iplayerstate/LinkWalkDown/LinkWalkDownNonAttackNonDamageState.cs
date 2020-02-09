using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iplayerstate
{
    class LinkWalkDownNonAttackNonDamageState: Iplayerstate
    {
        private Link linkPlayer; 

        //non damaged, non attack
        public LinkWalkDownNonAttackNonDamageState(Link link )
        {
            linkPlayer = link;
            linkPlayer = new LinkWalkDownNonAttackNonDamageSprite(texture);
        }

        public void ChangeToRight()
        {
            linkPlayer.state = new LinkWalkRightNonAttackNonDamageState(linkPlayer);
            
        }
        public void ChangToLeft()
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
            linkPlayer.state = new LinkWalkDownAttackNonDamageState(linkPlayer);
            

        }










    }
}
