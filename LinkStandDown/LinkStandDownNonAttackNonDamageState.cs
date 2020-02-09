using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.IPlayer;

namespace Sprint2.IPlayerState
{
    class LinkStandDownNonAttackNonDamageState:IPlayerState
    {
        private Link link;
        public LinkStandDownNonAttackNonDamageState(Link link)
        {
            link = new LinkStandDownNonAttackNonDamageSprite(texture);
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
            link.state = new LinkStandUpNonAttackNonDamageState(link);
        }
        public void ChangeToDown()
        {
            //alrady down
        }
        public void GetDamage()
        {
            link.state = new LinkStandDownNonAttackDamageState(link);
        }
        public void Attack()
        {
            link.state = new LinkStandDownAttackNonDamageState(link);
        }
        public void ChangeToWalk()
        {
            link.state = new LinkWalkDownNonAttackNonDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }
    }
}

