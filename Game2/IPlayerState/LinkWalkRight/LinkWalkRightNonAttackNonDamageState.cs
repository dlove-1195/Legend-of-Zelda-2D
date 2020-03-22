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
            link.ChangeDirection(3);

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
        public void GetDamaged()
        {
             
            linkPlayer.state = new LinkWalkRightNonAttackDamageState(linkPlayer);
            

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
            linkPlayer.state = new LinkStandRightNonAttackNonDamageState(linkPlayer);
        }


        public void LinkWithItemUp(int item)
        {
            linkPlayer.state = new LinkWithItemDownState(linkPlayer, item);
        }

        public void LinkWithItemDown(int item)
        {
            linkPlayer.state = new LinkWithItemDownState(linkPlayer, item);
        }

        public void LinkWithItemLeft(int item)
        {
            linkPlayer.state = new LinkWithItemLeftState(linkPlayer, item);
        }

        public void LinkWithItemRight(int item)
        {
            // linkPlayer.state = new LinkWithItemRightState(linkPlayer, item);
        }



    }
}
