using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.IPlayer;

namespace Sprint2.IPlayerState
{
    class LinkStandDownAttackDamageState:IPlayerState
    {
        private Link link;
        public LinkStandDownAttackDamageState(Link link)
        {
            link = new LinkStandDownAttackDamageSprite(texture);
            this.link = link;

        }
        public void ChangeToRight()
        {
            link.state = new LinkStandRightAttackDamageState(link);
        }
        public void ChangeToleft()
        {
            link.state = new LinkStandLeftAttackDamageState(link);
        }
        public void ChangeToUp()
        {
            link.state = new LinkStandUpAttackDamageState(link);
        }
        public void ChangeToDown(){}
        public void GetDamage() { }
        public void Attack() { }
        public void ChangeMovement()
        {
            link.state = new LinkWalkDownAttackDamageState(link);
        }
    }
}
