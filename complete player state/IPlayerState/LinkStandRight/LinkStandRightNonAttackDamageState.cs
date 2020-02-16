using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Sprint2 
{
    class LinkStandRightNonAttackDamageState:Iplayerstate
    {
        private Link link;
        public LinkStandRightNonAttackDamageState(Link link)
        {
            link = new LinkStandRightNonAttackDamageSprite(texture);
            this.link = link;
        }
        public void ChangeToRight()
        {
            //already right
        }
        public void ChangeToLeft()
        {
            link.state = new LinkStandLeftNonAttackDamageState(link);
        }
        public void ChangeToUp()
        {
            link.state = new LinkStandUpNonAttackDamageState(link);
        }
        public void ChangeToDown()
        {
            link.state = new LinkStandDownNonAttackDamageState(link);
        }
        public void GetDamaged()
        {
            //already damage
        }
        public void Attack()
        {
            link.state = new LinkStandRightAttackDamageState(link);
        }
        public void ChangeToWalk()
        {
            link.state = new LinkWalkRightNonAttackDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }
    }
}
