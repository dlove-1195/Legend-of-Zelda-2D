using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class EnemyCollisionHandler : ICollisionHandler
    {
        IEnemy enemy; 
        
        public EnemyCollisionHandler(IEnemy enemy)
        {
            this.enemy= enemy;
        }

        // public void HandleLinkNpcCollsion(String side);
        //may need add side in the future 
        public void HandleEnemyBlockCollsion()
        {
            enemy.ChangeToStand();
        }
        public void HandleEnemyCollsion()
        {
             enemy.GetDamaged();
        }
        
    }
}
