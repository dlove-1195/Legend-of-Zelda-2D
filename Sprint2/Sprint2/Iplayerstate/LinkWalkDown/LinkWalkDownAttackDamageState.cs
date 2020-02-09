using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iplayerstate
{
    class LinkWalkDownAttackDamageState: Iplayerstate
    {
        private Link linkPlayer;
        


        public LinkWalkDownAttackDamageState(Link link)
        {
            linkPlayer = link;
            linkPlayer = new LinkWalkDownAttackDamageSprite(texture);
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
            linkPlayer.state = new LinkWalkUpAttackDamageState(linkPlayer);
            

        }
        public void ChangeToDown()
        {

            // NO-OP
            // already down, do nothing

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
