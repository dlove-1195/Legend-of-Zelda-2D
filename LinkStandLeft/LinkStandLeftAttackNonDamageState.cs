using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.IPlayer;

namespace Sprint2.IPlayerState
{
    class LinkStandLeftAttackNonDamageState:IPlayerState
    {
        private Link link;
        public LinkStandLeftAttackNonDamageState(Link link)
        {
            link = new LinkStandLeftAttackNonDamageSprite(texture);
            this.link = link;

        }
        public void ChangeToRight()
        {
            link.state = new LinkStandRightAttackNonDamageState(link);
        }
        public void ChangeToleft()
        {
            //already left
        }
        public void ChangeToUp()
        {
            link.state = new LinkStandUpAttackNonDamageState(link);
        }
        public void ChangeToDown()
        {
            link.state = new LinkStandDownAttackNonDamageState(link);
        }
        public void GetDamage()
        {
            link.state = new LinkStandLeftAttackDamageState(link);
        }
        public void Attack()
        {
            //already attack
        }
        public void ChangeToWalk()
        {
            link.state = new LinkWalkLeftAttackNonDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }
    }
}
