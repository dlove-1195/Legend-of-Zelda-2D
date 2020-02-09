using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iplayerstate
{
    class LinkWalkLeftAttackDamageState: Iplayerstate
    {
        private Link linkPlayer;
        


        public LinkWalkLeftAttackDamageState(Link link)
        {
            linkPlayer = link;
            linkPlayer = new LinkWalkLeftAttackDamageSprite(texture);
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
            linkPlayer.state = new LinkWalkUpAttackDamageState(linkPlayer);
            

        }
        public void ChangeToDown()
        {
            linkPlayer.state = new LinkWalkDownAttackDamageState(linkPlayer);


        }
        public void GetDamaged()
        {
            // NO-OP
            // already damaged, do nothing

        }
        public void Attack()
        {
            // NO-OP
            // already attack, do nothing

        }

    }
}
