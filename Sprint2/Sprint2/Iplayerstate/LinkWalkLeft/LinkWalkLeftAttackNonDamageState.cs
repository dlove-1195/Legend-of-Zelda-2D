using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iplayerstate
{
    class LinkWalkLeftAttackNonDamageState: Iplayerstate
    {
        private Link linkPlayer;

       
        public LinkWalkLeftAttackNonDamageState(Link link)
        {
            linkPlayer = link;
            linkPlayer = new LinkWalkLeftAttackNonDamageSprite(texture);
        }

        public void ChangeToRight()
        {
            linkPlayer.state = new LinkWalkRightAttackDamageState(linkPlayer);
            

        }
        public void ChangToLeft()
        {
            // NO-OP
            // already left, do nothing


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
            linkPlayer.state = new LinkWalkLeftAttackDamageState(linkPlayer);
          

        }
        public void Attack()
        {
            // NO-OP
            // already attack, do nothing

        }

    }
}
