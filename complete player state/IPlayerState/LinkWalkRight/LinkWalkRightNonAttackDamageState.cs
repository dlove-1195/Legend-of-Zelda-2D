using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class LinkWalkRightNonAttackDamageState : Iplayerstate
    {
        private Link linkPlayer;
private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        
        public LinkWalkRightNonAttackDamageState(Link link)
        {
            linkPlayer = link;
            linkPlayer = new LinkWalkRightNonAttackDamageSprite(texture);
        }

        public void ChangeToRight()
        {
            // NO-OP
            // already right, do nothing

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
            linkPlayer.state = new LinkWalkRightAttackDamageState(linkPlayer);
             
        }

        public void ChangeToWalk()
        {
            //already walk
        }
        public void ChangeToStand()
        {
            linkPlayer.state = new LinkStandRightNonAttackDamageState(linkPlayer);
        }

    }
}
