using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.IPlayer;

namespace Sprint2.IplayerState
{
    class LinkStandRightNonAttackDamageState:IplayerState
    {
        private Link link;
        public LinkStandRightNonAttackDamageState(Link link)
        {
            link = new LinkStandRightNonAttackDamageSprite(texture);
            this.link = link;
        }
        public void ChangeToRight()
        {
            //already right
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
            link.state = new LinkStandDownNonAttackDamageState(link);
        }
        public void GetDamage()
        {
            //already damage
        }
        public void Attack()
        {
            link.state = new LinkStandRightAttackDamageState(link);
        }
    }
}
