using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iplayerstate
{
    class LinkWalkUpAttackNonDamageState: Iplayerstate
    {
        private Link linkPlayer;

       
        public LinkWalkUpAttackNonDamageState(Link link)
        {
            linkPlayer = link;
            linkPlayer = new LinkWalkUpAttackNonDamageSprite(texture);
        }

        public void ChangeToRight()
        {
            linkPlayer.state = new LinkWalkRightAttackNonDamageState(linkPlayer);
            
        }
        public void ChangToLeft()
        {
            linkPlayer.state = new LinkWalkLeftAttackNonDamageState(linkPlayer);
           

        }
        public void ChangeToUp()
        {
            // NO-OP
            // already up, do nothing

        }
        public void ChangeToDown()
        {
            linkPlayer.state = new LinkWalkDownAttackNonDamageState(linkPlayer);
            

        }
        public void GetDamaged()
        {
            linkPlayer.state = new LinkWalkUpAttackDamageState(linkPlayer);
          

        }
        public void Attack()
        {
            // NO-OP
            // already attack, do nothing

        }

    }
}
