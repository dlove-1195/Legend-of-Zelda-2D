using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Sprint2 
{
    class LinkStandRightAttackDamageState:Iplayerstate
    {
        private Link link;
        public LinkStandRightAttackDamageState(Link link)
        {
            link = new LinkStandRightAttackDamageSprite(texture);
            this.link = link;

        }
        public void ChangeToRight()
        {
            //already right
        }
        public void ChangeToLeft()
        {
            link.state = new LinkStandLeftAttackDamageState(link);
        }
        public void ChangeToUp()
        {
            link.state = new LinkStandUpAttackDamageState(link);
        }
        public void ChangeToDown()
        {
            link.state = new LinkStandDownAttackDamageState(link);
        }
        public void GetDamaged()
        {
            //already damage
        }
        public void Attack()
        {
            //already attack
        }
        public void ChangeToWalk()
        {
            link.state = new LinkWalkRightAttackDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }
    }
}
