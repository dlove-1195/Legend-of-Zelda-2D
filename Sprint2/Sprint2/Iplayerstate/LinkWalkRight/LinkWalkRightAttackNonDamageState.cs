using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iplayerstate
{
    class LinkWalkRightAttackNonDamageState: Iplayerstate
    {
        private Link linkPlayer;

       
        public LinkWalkRightAttackNonDamageState(Link link)
        {
            linkPlayer = link;
            linkPlayer = new LinkWalkRightAttackNonDamageSprite(texture);
        }

        public void ChangeToRight()
        {
            // NO-OP
            // already right, do nothing

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

            linkPlayer.state = new LinkWalkDownAttackNonDamageState(linkPlayer);


        }
        public void GetDamaged()
        {
            linkPlayer.state = new LinkWalkRightAttackDamageState(linkPlayer);
          

        }
        public void Attack()
        {
            // NO-OP
            // already attack, do nothing

        }

    }
}
