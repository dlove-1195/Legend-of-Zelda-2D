using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.IPlayer;

namespace Sprint2.IplayerState
{
    class LinkStandUpAttackNonDamageState:IplayerState
    {
        private Link link;
        public LinkStandUpAttackNonDamageState(Link link)
        {
            link = new LinkStandUpAttackNonDamageSprite(texture);
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
            //already up
        }
        public void ChangeToDown()
        {
            link.state = new LinkStandDownAttackNonDamageState(link);
        }
        public void GetDamage()
        {
            link.state = new LinkStandUpAttackDamageState(link);
        }
        public void Attack()
        {
            //already attack
        }
    }
}
