using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Sprint2 
{
    public class LinkStandUpAttackNonDamageState:Iplayerstate
    {
        private Link link;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        public LinkStandUpAttackNonDamageState(Link link)
        {
            link.linkSprite = new LinkAttackUpSprite(texture);
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
            link.state = new LinkStandUpNonAttackNonDamageState(link);
        }
        public void ChangeToDown()
        {
            link.state = new LinkStandDownNonAttackNonDamageState(link);
        }
        public void GetDamaged()
        {
             
        }
        public void Attack()
        {
            link.state = new LinkStandUpAttackNonDamageState(link);
        }
        public void ChangeToWalk()
        {
            
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
