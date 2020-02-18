using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Sprint2 
{
    public class LinkStandLeftNonAttackDamageState:Iplayerstate
    {
        private Link link;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet2();
        public LinkStandLeftNonAttackDamageState(Link link)
        {
            link.linkSprite = new LinkDamageStandLeftSprite(texture);
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
            link.linkSprite = new LinkDamageStandLeftSprite(texture);

        }
            public void Attack()
        {
            //cannot attack when get damaged
        }
        public void ChangeToWalk()
        {
            link.state = new LinkWalkLeftNonAttackNonDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }
        public void LinkWithBomb()
        {
            link.state = new LinkLeftWithBombState(link);
        }

        public void LinkWithSword()
        {
            link.state = new LinkLeftWithSwordState(link);
        }
    }
}
