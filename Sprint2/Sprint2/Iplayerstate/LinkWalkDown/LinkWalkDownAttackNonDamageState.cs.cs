using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iplayerstate
{
    class LinkWalkDownAttackNonDamageState: Iplayerstate
    {
        private Link linkPlayer;

       
        public LinkWalkDownAttackNonDamageState(Link link)
        {
            linkPlayer = link;
            linkPlayer = new LinkWalkDownAttackNonDamageSprite(texture);
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
            linkPlayer.state = new LinkWalkUpAttackNonDamageState(linkPlayer);

        }
        public void ChangeToDown()
        {
            // NO-OP
            // already down, do nothing



        }
        public void GetDamaged()
        {
            linkPlayer.state = new LinkWalkDownAttackDamageState(linkPlayer);
          

        }
        public void Attack()
        {
            // NO-OP
            // already attack, do nothing

        }

    }
}
