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
            this.link.ChangeX(2);


        }
        
        public void ChangeToRight()
        {
            if (Link.ifDamage)
            {
                link.state = new LinkStandRightNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkStandRightNonAttackNonDamageState(link);
            }
        }
        public void ChangeToLeft()
        {
            if (Link.ifDamage)
            {
                link.state = new LinkStandLeftNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkStandLeftNonAttackNonDamageState(link);
            }
        }
        public void ChangeToUp()
        {
            if (Link.ifDamage)
            {
                link.state = new LinkStandUpNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkStandUpNonAttackNonDamageState(link);
            }
        }
        public void ChangeToDown()
        {
            if (Link.ifDamage)
            {
                link.state = new LinkStandDownNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkStandDownNonAttackNonDamageState(link);
            }
        }
        public void GetDamaged()
        {
            link.state = new LinkStandLeftNonAttackDamageState(link);

        }
            public void Attack()
        {
            //cannot attack when get damaged
        }
        public void ChangeToWalk()
        {

            if (Link.ifDamage)
            {
                link.state = new LinkWalkLeftNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkWalkLeftNonAttackNonDamageState(link);
            }
        }
        public void ChangeToStand()
        {
            if (!Link.ifDamage)
            {
                link.state = new LinkStandLeftNonAttackNonDamageState(link);
            }
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
