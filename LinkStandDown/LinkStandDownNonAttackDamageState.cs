using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.IPlayer;

namespace Sprint2.IPlayerState
{
    class LinkStandDownNonAttackDamageState: IPlayerState
    {
        private Link link;
        public LinkStandDownNonAttackDamageState(Link link)
        {
            link = new LinkStandDownNonAttackDamageSprite(texture);
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
            link.state = new LinkStandUpNonAttackDamageState(link);
        }
        public void ChangeToDown()
        {
            //alrady down
        }
        public void GetDamage()
        {
            //already get damage
        }
        public void Attack()
        {
            link.state = new LinkStandDownAttackDamageState(link);
        }
        public void ChangeToWalk()
        {
            link.state = new LinkWalkDownNonAttackDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }
    }
}

