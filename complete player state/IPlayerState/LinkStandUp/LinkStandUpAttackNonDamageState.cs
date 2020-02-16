using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Sprint2 
{
    class LinkStandUpAttackNonDamageState:Iplayerstate
    {
        private Link link;
        public LinkStandUpAttackNonDamageState(Link link)
        {
            link = new LinkStandUpAttackNonDamageSprite(texture);
            this.link = link;
        }
        public void ChangeToRight()
        {
            link.state = new LinkStandRightAttackNonDamageState(link);
        }
        public void ChangeToLeft()
        {
            link.state = new LinkStandLeftAttackNonDamageState(link);
        }
        public void ChangeToUp()
        {
            //already up
        }
        public void ChangeToDown()
        {
            link.state = new LinkStandDownAttackNonDamageState(link);
        }
        public void GetDamaged()
        {
            link.state = new LinkStandUpAttackDamageState(link);
        }
        public void Attack()
        {
            //already attack
        }
        public void ChangeToWalk()
        {
            link.state = new LinkWalkUpAttackNonDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }
    }
}
