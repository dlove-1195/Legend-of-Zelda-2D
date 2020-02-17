using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Sprint2 
{
    public class LinkStandRightNonAttackDamageState:Iplayerstate
    {
        private Link link;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        public LinkStandRightNonAttackDamageState(Link link)
        {
            link.linkSprite = new LinkDamageStandRightSprite(texture);
            this.link = link;
        }
        public void ChangeToRight()
        {
            link.state = new LinkStandRightNonAttackNonDamageState(link);
        }
        public void ChangeToLeft()
        {
            link.state = new LinkStandLeftNonAttackNonDamageState(link);
        }
        public void ChangeToUp()
        {
            link.state = new LinkStandUpNonAttackNonDamageState(link);
        }
        public void ChangeToDown()
        {
            link.state = new LinkStandDownNonAttackNonDamageState(link);
        }
        public void GetDamaged()
        {
            //already damage
        }
        public void Attack()
        {
            //cannot attack when damage
        }
        public void ChangeToWalk()
        { //actually never use ??
            link.state = new LinkWalkRightNonAttackNonDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }

        public void LinkWithBomb()
        {
            link.state = new LinkRightWithBombState(link);
        }

        public void LinkWithSword()
        {
            link.state = new LinkRightWithSwordState(link);
        }
    }
}
