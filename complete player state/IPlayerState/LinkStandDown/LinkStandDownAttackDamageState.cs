using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    class LinkStandDownAttackDamageState: Iplayerstate
    {
        private Link link;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        public LinkStandDownAttackDamageState(Link link)
        {
            link = new LinkStandDownAttackDamageSprite(texture);
            this.link = link;

        }
        public void ChangeToRight()
        {
            link.state = new LinkStandRightAttackDamageState(link);
        }
        public void ChangeToLeft()
        {
            link.state = new LinkStandLeftAttackDamageState(link);
        }
        public void ChangeToUp()
        {
            link.state = new LinkStandUpAttackDamageState(link);
        }
        public void ChangeToDown(){}
        public void GetDamaged() { }
        public void Attack() { }
        public void ChangeToWalk()
        {
            link.state = new LinkWalkLeftAttackDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }
    }
}
