using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.IPlayer;

namespace Sprint2.IPlayerState
{
    class LinkStandUpNonAttackDamageState: IPlayerState
    {
        private Link link;
        public LinkStandUpNonAttackDamageState(Link link)
        {
            link = new LinkStandUpNonAttackDamageSprite(texture);
            this.link = link;
        }
        public void ChangeToRight()
        {
            link.state = new LinkStandRightNonAttackDamageState(link);
        }
        public void ChangeToleft()
        {
            link.state = new LinkStandLeftNonAttackDamageState(link);
        }
        public void ChangeToUp()
        {
            //already up
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
            link.state = new LinkStandUpAttackDamageState(link);
        }
        public void ChangeToWalk()
        {
            link.state = new LinkWalkUpNonAttackDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }
    }
}
