using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class LinkWalkUpNonAttackDamageState : Iplayerstate
    {
        private Link linkPlayer;
private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        
        public LinkWalkUpNonAttackDamageState(Link link)
        {
            linkPlayer = link;
            linkPlayer = new LinkWalkUpNonAttackDamageSprite(texture);
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
            // NO-OP
            // already up, do nothing

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
            linkPlayer.state = new LinkWalkUpAttackDamageState(linkPlayer);
             
        }

        public void ChangeToWalk()
        {
            //already walk
        }
        public void ChangeToStand()
        {
            linkPlayer.state = new LinkStandUpNonAttackDamageState(linkPlayer);
        }


    }
}
