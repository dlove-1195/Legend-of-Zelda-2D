using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Sprint2 
{
    public class LinkStandDownNonAttackDamageState: Iplayerstate
    {
        private Link link;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet2();
        public LinkStandDownNonAttackDamageState(Link link)
        {
            link.linkSprite = new LinkDamageStandDownSprite(texture);
            this.link = link;
            Link.ifDamage = true;
            this.link.ChangeX(1);

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
            link.state = new LinkStandDownNonAttackDamageState(link);
        }
        public void Attack()
        {
            //cannot attack and damage at the same time
        }
        public void ChangeToWalk()
        {
            link.state = new LinkWalkDownNonAttackDamageState(link);
            /*if (Link.ifDamage)
            {
                link.state = new LinkWalkDownNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkWalkDownNonAttackNonDamageState(link);
            }*/
        }
        public void ChangeToStand()
        {
            if(!Link.ifDamage)
            {
                link.state = new LinkStandDownNonAttackNonDamageState(link);
            }
        }

        public void LinkWithItemUp(Iitem item)
        {
            link.state = new LinkWithItemUpState(link, item);
        }

        public void LinkWithItemDown(Iitem item)
        {
            //do nothing
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

