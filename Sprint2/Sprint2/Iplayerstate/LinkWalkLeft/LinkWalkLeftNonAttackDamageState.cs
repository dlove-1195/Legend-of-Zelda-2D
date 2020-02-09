using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iplayerstate
{
    class LinkWalkLeftNonAttackDamageState : Iplayerstate
    {
        private Link linkPlayer;

        
        public LinkWalkLeftNonAttackDamageState(Link link)
        {
            linkPlayer = link;
            linkPlayer = new LinkWalkLeftNonAttackDamageSprite(texture);
        }

        public void ChangeToRight()
        {
            linkPlayer.state = new LinkWalkRightNonAttackDamageState(linkPlayer);

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
            linkPlayer.state = new LinkWalkLeftAttackDamageState(linkPlayer);
             
        }


    }
}
