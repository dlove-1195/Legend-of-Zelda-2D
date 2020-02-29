using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2 
{
    class LinkStandDownNonAttackNonDamageState:Iplayerstate
    {
        private Link link;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        public LinkStandDownNonAttackNonDamageState(Link link)
        {
            
            this.link = link;
            link.linkSprite = new LinkStandDownSprite(texture);
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
            //alrady down
        }
        public void GetDamaged()
        {
            link.state = new LinkStandDownNonAttackDamageState(link);
        }
        public void Attack()
        {
            link.state = new LinkStandDownAttackNonDamageState(link);
        }
        public void ChangeToWalk()
        {
            link.state = new LinkWalkDownNonAttackNonDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }
    }
}

