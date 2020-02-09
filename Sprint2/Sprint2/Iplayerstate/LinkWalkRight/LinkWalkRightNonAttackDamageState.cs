using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iplayerstate
{
    class LinkWalkRightNonAttackDamageState : Iplayerstate
    {
        private Link linkPlayer;

        
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
        public void ChangToLeft()
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


    }
}
