using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Sprint2 
{
    public class LinkStandLeftNonAttackNonDamageState: Iplayerstate
    {
        private Link link;
         
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet() ; 
        public LinkStandLeftNonAttackNonDamageState(Link link)
        {
            this.link = link;
            link.linkSprite = new LinkStandLeftSprite(texture);
             
        }
        public void ChangeToRight()
        {
            link.state = new LinkStandRightNonAttackNonDamageState(link);
        }
        public void ChangeToLeft()
        {
            //already left
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
            link.state = new LinkStandLeftNonAttackDamageState(link);
            Link.ifDamage = true;
        }
        public void Attack()
        {
            link.state = new LinkStandLeftAttackNonDamageState(link);
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
