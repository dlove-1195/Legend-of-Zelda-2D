using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Sprint2 
{
    class LinkStandUpNonAttackDamageState: Iplayerstate
    {
        private Link link;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        public LinkStandUpNonAttackDamageState(Link link)
        {
            link = new LinkStandUpNonAttackDamageSprite(texture);
            this.link = link;
        }
        public void ChangeToRight()
        {
            link.state = new LinkStandRightNonAttackDamageState(link);
        }
        public void ChangeToLeft()
        {
            link.state = new LinkStandLeftNonAttackDamageState(link);
        }
        public void ChangeToUp()
        {
            //already up
        }
        public void ChangeToDown()
        {
            link.state = new LinkStandDownNonAttackDamageState(link);
        }
        public void GetDamaged()
        {
            //already damage
        }
        public void Attack()
        {
            link.state = new LinkStandUpAttackDamageState(link);
        }
        public void ChangeToWalk()
        {
            link.state = new LinkWalkUpNonAttackDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }
    }
}
