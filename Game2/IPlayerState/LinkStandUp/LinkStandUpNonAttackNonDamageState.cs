using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Sprint2 
{
    public class LinkStandUpNonAttackNonDamageState:Iplayerstate
    {
        private Link link;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        public LinkStandUpNonAttackNonDamageState(Link link)
        {
            link.linkSprite = new LinkStandUpSprite(texture);
            this.link = link;
            this.link.ChangeX(0);

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
            //already up
        }
        public void ChangeToDown()
        {
            link.state = new LinkStandDownNonAttackNonDamageState(link);
        }
        public void GetDamaged()
        {
            link.state = new LinkStandUpNonAttackDamageState(link);
            Link.ifDamage = true;
        }
        public void Attack()
        {
            link.state = new LinkStandUpAttackNonDamageState(link);
        }
        public void ChangeToWalk()
        {
            link.state = new LinkWalkUpNonAttackNonDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }

        public void LinkWithItemUp(Iitem item)
        {
            //do nothing
        }

        public void LinkWithItemDown(Iitem item)
        {
            link.state = new LinkWithItemDownState(link, item);
        }

        public void LinkWithItemLeft(Iitem item)
        {
            link.state = new LinkWithItemLeftState(link, item);
        }

        public void LinkWithItemRight(Iitem item)
        {
            link.state = new LinkWithItemRightState(link, item);
        }
    }
}
