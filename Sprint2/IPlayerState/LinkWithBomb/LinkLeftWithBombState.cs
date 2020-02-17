using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class LinkLeftWithBombState: Iplayerstate
    {
        private Link link;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        public LinkLeftWithBombState(Link link)
        {
            this.link = link;
            link.linkSprite = new LinkStandLeftSprite(texture);
            link.bomb = new Bomb((Link.posX-20), Link.posY);
            

        }
        public void ChangeToRight()
        {
            link.state = new LinkStandRightAttackNonDamageState(link);
        }
        public void ChangeToLeft()
        {
            link.state = new LinkStandLeftAttackNonDamageState(link);
        }
        public void ChangeToUp()
        {
            link.state = new LinkStandUpAttackNonDamageState(link);
        }
        public void ChangeToDown()
        {
            link.state = new LinkStandDownAttackNonDamageState(link);
        }
        public void GetDamaged()
        {
            //cannot attack and damage at the same time
        }
        public void Attack()
        {
            //already attack
        }
        public void ChangeToWalk()
        {
            //cannot walk when attack
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
