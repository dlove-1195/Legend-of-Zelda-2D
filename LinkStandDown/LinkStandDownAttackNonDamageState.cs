using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.IPlayer;

namespace Sprint2.IPlayerState
{
    class LinkStandDownAttackNonDamageState: IPlayerState
    {
        private Link link;
        public LinkStandDownAttackNonDamageState(Link link)
        {
            link = new LinkStandDownAttackNonDamageSprite(texture);
            this.link = link;
        }
        public void ChangeToRight()
        {
            link.state = new LinkStandRightAttackNonDamageState(link);
        }
        public void ChangeToleft()
        {
            link.state = new LinkStandLeftAttackNonDamageState(link);
        }
        public void ChangeToUp()
        {
            link.state = new LinkStandUpAttackNonDamageState(link);
        }
        public void ChangeToDown(){}
        public void GetDamage()
        {
            link.state = new LinkStandUpAttackDamageState(link);
        }
        public void Attack() {}
        public void ChangeToWalk()
        {
            link.state = new LinkWalkDownAttackNonDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }
    }
}
