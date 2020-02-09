using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.IPlayer;

namespace Sprint2.IPlayerState
{
    class LinkStandRightNonAttackNonDamageState: IPlayerState
    {
        private Link link;
        public LinkStandRightNonAttackNonDamageState(Link link)
        {
            link = new LinkStandRightNonAttackNonDamageSprite(texture);
            this.link = link;
        }
        public void ChangeToRight()
        {
            //already right
        }
        public void ChangeToleft()
        {
            link.state = new LinkStandLeftNonAttackNonDamageState(link);
        }
        public void ChangeToUp()
        {
            link.state = new LinkStandUpNonAttackNonDamageState(link);
        }
        public void ChangeToDown()
        {
            link.state = new LinkStandDownNonAttackNonDamageState(link);
        }
        public void GetDamage()
        {
            link.state = new LinkStandRightNonAttackDamageState(link);
        }
        public void Attack()
        {
            link.state = new LinkStandRightAttackNonDamageState(link);
        }
        public void ChangeToWalk()
        {
            link.state = new LinkWalkRightNonAttackNonDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }
    }
}
