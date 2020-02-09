using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iplayerstate
{
    class LinkWalkLeftNonAttackNonDamageState: Iplayerstate
    {
        private Link linkPlayer; 

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
        public void ChangToLeft()
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










    }
}
