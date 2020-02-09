using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.IPlayer;

namespace Sprint2.IplayerState
{
    class LinkStandLeftAttackDamageState: IplayerState
    {
        private Link link;
        public LinkStandLeftAttackDamageState(Link link)
        {
            link = new LinkStandLeftAttackDamageSprite(texture);
            this.link = link;

        }
        public void ChangeToRight()
        {
            link.state = new LinkStandRightAttackDamageState(link);
        }
        public void ChangeToleft()
        {
            //already left
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

