using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class LinkWalkLeftNonAttackDamageState : Iplayerstate
    {
        private Link linkPlayer;

        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        public LinkWalkLeftNonAttackDamageState(Link link)
        {
            linkPlayer = link;
            linkPlayer.linkSprite = new LinkDamageWalkLeftSprite(texture);
        }

        public void ChangeToRight()
        {
            linkPlayer.state = new LinkWalkRightNonAttackDamageState(linkPlayer);

        }
        public void ChangeToLeft()
        {
            linkPlayer.state = new LinkWalkLeftNonAttackDamageState(linkPlayer);
             

        }
        public void ChangeToUp()
        {
            linkPlayer.state = new LinkWalkUpNonAttackDamageState(linkPlayer);

        }
        public void ChangeToDown()
        {
            linkPlayer.state = new LinkWalkDownNonAttackDamageState(linkPlayer);


        }
        public void GetDamaged()
        {
            // NO-OP
            // already damage, do nothing

        }
        public void Attack()
        {
            
             
        }

        public void ChangeToWalk()
        {
            //already walk
        }
        public void ChangeToStand()
        {
            linkPlayer.state = new LinkStandLeftNonAttackDamageState(linkPlayer);
        }

        public void LinkWithBomb()
        {

        }

        public void LinkWithSword()
        {

        }

    }
}
