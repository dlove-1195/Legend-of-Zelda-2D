using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.IPlayer;

namespace Sprint2.IplayerState
{
    class LinkStandRightAttackNonDamageState:IplayerState
    {
        private Link link;
        public LinkStandRightAttackNonDamageState(Link link)
        {
            link = new LinkStandRightAttackNonDamageSprite(texture);
            this.link = link;
        }
        public void ChangeToRight()
        {
            //already right
        }
        public void ChangeToleft()
        {
            link.state = new LinkStandLeftAttackNonDamageState(link);
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
            link.state = new LinkStandRightAttackDamageState(link);
        }
        public void Attack()
        {
            //already attack
        }
    }
}
