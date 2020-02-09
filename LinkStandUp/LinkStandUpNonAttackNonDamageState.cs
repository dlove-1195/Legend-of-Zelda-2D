using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.IPlayer;

namespace Sprint2.IPlayerState
{
    class LinkStandUpNonAttackNonDamageState:IPlayerState
    {
        private Link link;
        public LinkStandUpNonAttackNonDamageState(Link link)
        {
            link = new LinkStandUpNonAttackNonDamageSprite(texture);
            this.link = link;
        }
        public void ChangeToRight()
        {
            link.state = new LinkStandRightNonAttackNonDamageState(link);
        }
        public void ChangeToleft()
        {
            link.state = new LinkStandLeftNonAttackNonDamageState(link);
        }
        public void ChangeToUp()
        {
            //already up
        }
        public void ChangeToDown()
        {
            link.state = new LinkStandDownNonAttackNonDamageState(link);
        }
        public void GetDamage()
        {
            link.state = new LinkStandUpNonAttackDamageState(link);
        }
        public void Attack()
        {
            link.state = new LinkStandUpAttackNonDamageState(link);
        }
        public void ChangeToWalk()
        {
            link.state = new LinkWalkUpNonAttackNonDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }
    }
}
