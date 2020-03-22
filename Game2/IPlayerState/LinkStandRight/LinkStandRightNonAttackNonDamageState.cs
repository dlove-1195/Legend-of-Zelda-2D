using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2 
{
   public class LinkStandRightNonAttackNonDamageState: Iplayerstate
    {
        private Link link;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        public LinkStandRightNonAttackNonDamageState(Link link)
        {
            
            this.link = link;
            link.linkSprite = new LinkStandRightSprite(texture);
            this.link.ChangeDirection(3);

        }
      
        public void ChangeToRight()
        {
            //already right
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
            link.state = new LinkStandRightNonAttackDamageState(link);
             
        }
        public void Attack()
        {
            link.state = new LinkStandRightAttackNonDamageState(link);
        }
        public void ChangeToWalk()
        {
            link.state = new LinkWalkRightNonAttackNonDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }

        public void LinkWithItemUp(int item)
        {
            link.state = new LinkWithItemUpState(link, item);
        }

        public void LinkWithItemDown(int item)
        {
            link.state = new LinkWithItemDownState(link, item);
        }

        public void LinkWithItemLeft(int item)
        {
            link.state = new LinkWithItemLeftState(link, item);
        }

        public void LinkWithItemRight(int item)
        {
            link.state = new LinkWithItemRightState(link, item);
        }
    }
}
