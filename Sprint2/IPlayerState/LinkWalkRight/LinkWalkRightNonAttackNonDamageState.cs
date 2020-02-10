using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class LinkWalkRightNonAttackNonDamageState: Iplayerstate
    {
        private Link linkPlayer;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        //non damaged, non attack
        public LinkWalkRightNonAttackNonDamageState(Link link )
        {
            linkPlayer = link;
            
            linkPlayer.linkSprite = new LinkWalkRightSprite(texture);
        }

        public void ChangeToRight()
        {
            // NO-OP
            // already right, do nothing
        }
        public void ChangeToLeft()
        {
            linkPlayer.state = new LinkWalkLeftNonAttackNonDamageState(linkPlayer);
             

        }
        public void ChangeToUp()
        {
            linkPlayer.state = new LinkWalkUpNonAttackNonDamageState(linkPlayer);
             

        }
        public void ChangeToDown()
        {

            linkPlayer.state = new LinkWalkDownNonAttackNonDamageState(linkPlayer);
        }
         
        public void ChangeToWalk()
        {
            //already walk
        }
        public void ChangeToStand()
        {
            linkPlayer.state = new LinkStandRightNonAttackNonDamageState(linkPlayer);
        }









    }
}
