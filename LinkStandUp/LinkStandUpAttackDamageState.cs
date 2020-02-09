using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.IPlayer;

namespace Sprint2.IPlayerState
{
    class LinkStandUpAttackDamageState:IPlayerState
    {
        private Link link;
        public LinkStandUpAttackDamageState(Link link)
        {
            link = new LinkStandUpAttackDamageSprite(texture);
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
            //already up
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
        public void ChangeToWalk()
        {
            link.state = new LinkWalkUpAttackDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }
    }
}
