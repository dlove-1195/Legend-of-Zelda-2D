using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Sprint2 
{
    public class LinkStandLeftAttackNonDamageState:Iplayerstate
    {
        private Link link;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        public LinkStandLeftAttackNonDamageState(Link link)
        {
            link.linkSprite = new LinkAttackLeftSprite(texture);
            this.link = link;
            this.link.ChangeX(2);
          

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
            //cannot attack and damage at the same time
        }
        public void Attack()
        {
           link.state=new LinkStandLeftAttackNonDamageState(link);
        }
        public void ChangeToWalk()
        {
             //cannot walk when attack
        }
        public void ChangeToStand()
        {
            //already stand
        }

        public void LinkWithItemUp(Iitem item)
        {
            link.state = new LinkWithItemUpState(link, item);
        }

        public void LinkWithItemDown(Iitem item)
        {
            link.state = new LinkWithItemDownState(link, item);
        }

        public void LinkWithItemLeft(Iitem item)
        {
            //do nothing
        }

        public void LinkWithItemRight(Iitem item)
        {
            link.state = new LinkWithItemRightState(link, item);
        }
    }
}
