using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iplayerstate
{
    class LinkWalkRightNonAttackNonDamageState: Iplayerstate
    {
        private Link linkPlayer; 

        //non damaged, non attack
        public LinkWalkRightNonAttackNonDamageState(Link link )
        {
            linkPlayer = link;
            linkPlayer = new LinkWalkRightNonAttackNonDamageSprite(texture);
        }

        public void ChangeToRight()
        {
            // NO-OP
            // already right, do nothing
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

            linkPlayer.state = new LinkWalkDownNonAttackNonDamageState(linkPlayer);
        }
        public void GetDamaged()
        {
            linkPlayer.state = new LinkWalkRightNonAttackDamageState(linkPlayer);
            

        }
        public void Attack()
        {
            linkPlayer.state = new LinkWalkRightAttackNonDamageState(linkPlayer);
            

        }










    }
}
