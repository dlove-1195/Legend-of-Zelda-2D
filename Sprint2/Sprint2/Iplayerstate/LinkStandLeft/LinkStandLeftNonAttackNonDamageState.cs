using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.IPlayer;

namespace Sprint2.IPlayerState
{
    class LinkStandLeftNonAttackNonDamageState: IPlayerState
    {
        private Link link;
        public LinkStandLeftNonAttackNonDamageState(Link link)
        {
            link = new LinkStandLeftNonAttackNonDamageSprite(texture);
            this.link = link;
        }
        public void ChangeToRight()
        {
            link.state = new LinkStandRightNonAttackNonDamageState(link);
        }
        public void ChangeToleft()
        {
            //already left
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
            link.state = new LinkStandLeftNonAttackDamageState(link);
        }
        public void Attack()
        {
            link.state = new LinkStandLeftAttackNonDamageState(link);
        }
        public void ChangeMovement()
        {
            link.state = new LinkWalkLeftNonAttackNonDamageState(link);
        }
    }
}
