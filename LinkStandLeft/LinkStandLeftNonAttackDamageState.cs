using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.IPlayer;

namespace Sprint2.IPlayerState
{
    class LinkStandLeftNonAttackDamageState:IPlayerState
    {
        private Link link;
        public LinkStandLeftNonAttackDamageState(Link link)
        {
            link = new LinkStandLeftNonAttackDamageSprite(texture);
            this.link = link;

        }
        public void ChangeToRight()
        {
            link.state = new LinkStandRightNonAttackDamageState(link);
        }
        public void ChangeToleft()
        {
            //already left
        }
        public void ChangeToUp()
        {
            link.state = new LinkStandUpNonAttackDamageState(link);
        }
        public void ChangeToDown()
        {
            link.state = new LinkStandDownNonAttackDamageState(link);
        }
        public void GetDamage()
        {
            //already damage
        }
        public void Attack()
        {
            link.state = new LinkStandLeftAttackDamageState(link);
        }
        public void ChangeToWalk()
        {
            link.state = new LinkWalkLeftNonAttackDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }
    }
}
