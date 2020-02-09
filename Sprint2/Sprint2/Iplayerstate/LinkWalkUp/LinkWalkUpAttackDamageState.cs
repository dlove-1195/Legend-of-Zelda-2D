using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iplayerstate
{
    class LinkWalkUpAttackDamageState: Iplayerstate
    {
        private Link linkPlayer;
        


        public LinkWalkUpAttackDamageState(Link link)
        {
            linkPlayer = link;
            linkPlayer = new LinkWalkUpAttackDamageSprite(texture);
        }

        public void ChangeToRight()
        {
            linkPlayer.state = new LinkWalkRightAttackDamageState(linkPlayer);
            
        }
        public void ChangToLeft()
        {
            linkPlayer.state = new LinkWalkLeftAttackDamageState(linkPlayer);
            

        }
        public void ChangeToUp()
        {
            // NO-OP
            // already up, do nothing

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
