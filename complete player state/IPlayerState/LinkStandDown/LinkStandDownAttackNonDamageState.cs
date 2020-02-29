using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Sprint2 { 
    class LinkStandDownAttackNonDamageState: Iplayerstate
    {
        private Link link;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        public LinkStandDownAttackNonDamageState(Link link)
        {
            link = new LinkStandDownAttackNonDamageSprite(texture);
            this.link = link;
        }
        public void ChangeToRight()
        {
            link.state = new LinkStandRightAttackNonDamageState(link);
        }
        public void ChangeToLeft()
        {
            link.state = new LinkStandLeftAttackNonDamageState(link);
        }
        public void ChangeToUp()
        {
            link.state = new LinkStandUpAttackNonDamageState(link);
        }
        public void ChangeToDown(){}
        public void GetDamaged()
        {
            link.state = new LinkStandUpAttackDamageState(link);
        }
        public void Attack() {}
        public void ChangeToWalk()
        {
            link.state = new LinkWalkDownAttackNonDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }
    }
}
