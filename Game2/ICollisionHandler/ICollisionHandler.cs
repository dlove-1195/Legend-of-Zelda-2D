using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    interface ICollisionHandler
    {
        //void HandleLinkNpcCollsion(String side);
        //may need add side in the future 
        void HandleLinkBlockCollsion( );
        void HandleLinkEnemyCollsion( );
        void HandleLinkNpcCollsion( );
        void HandleLinkItemCollsion();

    }
}
