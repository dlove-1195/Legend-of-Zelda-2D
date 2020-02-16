using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Sprint2 
{
    class LinkStandUpAttackDamageState:Iplayerstate
    {
        private Link link;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        public LinkStandUpAttackDamageState(Link link)
        {
            link = new LinkStandUpAttackDamageSprite(texture);
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
            //already up
        }
        public void ChangeToDown()
        {
            link.state = new LinkStandDownAttackDamageState(link);
        }
        public void GetDamaged()
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
