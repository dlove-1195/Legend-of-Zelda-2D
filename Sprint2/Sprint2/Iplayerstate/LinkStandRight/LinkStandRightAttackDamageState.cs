using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.IPlayer;

namespace Sprint2.IplayerState
{
    class LinkStandRightAttackDamageState:IplayerState
    {
        private Link link;
        public LinkStandRightAttackDamageState(Link link)
        {
            link = new LinkStandRightAttackDamageSprite(texture);
            this.link = link;

        }
        public void ChangeToRight()
        {
            //already right
        }
        public void ChangeToleft()
        {
            link.state = new LinkStandLeftAttackDamageState(link);
        }
        public void ChangeToUp()
        {
            link.state = new LinkStandUpAttackDamageState(link);
        }
        public void ChangeToDown()
        {
            link.state = new LinkStandDownAttackDamageState(link);
        }
        public void GetDamage()
        {
            //already damage
        }
        public void Attack()
        {
            //already attack
        }
    }
}
