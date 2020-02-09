using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iplayerstate
{
    class LinkWalkRightAttackDamageState: Iplayerstate
    {
        private Link linkPlayer;
        


        public LinkWalkRightAttackDamageState(Link link)
        {
            linkPlayer = link;
            linkPlayer = new LinkWalkRightAttackDamageSprite(texture);
        }

        public void ChangeToRight()
        {
            // NO-OP
            // already right, do nothing

        }
        public void ChangToLeft()
        {
            linkPlayer.state = new LinkWalkLeftAttackDamageState(linkPlayer);
            

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
