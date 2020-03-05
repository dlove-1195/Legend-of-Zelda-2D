using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class LinkCollisionHandler : ICollisionHandler
    {

        Iplayer link; 
        public LinkCollisionHandler(Iplayer link)
        {
            this.link = link;
        }

        // public void HandleLinkNpcCollsion(String side);
        //may need add side in the future 
        public void HandleLinkBlockCollsion()
        {
            link.ChangeToStand();
        }
        public void HandleLinkEnemyCollsion()
        {
            link.GetDamaged();
        }
        public void HandleLinkNpcCollsion()
        {
            link.ChangeToStand();
            //may need to draw something on the screen
            //to show the communication with npc
        }

        public void HandleLinkItemCollsion()
        {
            link.ChangeToStand();
            //may need to let item disappear to represent pick up action 
        }
    }
}
