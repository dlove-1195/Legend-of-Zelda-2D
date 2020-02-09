using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.IplayerState;


namespace Sprint2.Iplayer
{ 
  class Link:Iplayer 
    {
        public IplayerState state;
        public Link()
        {
            state = new LinkStandLeftNonAttackNonDamage(this);
        }
        public void ChangeToRight()
        {
            state.ChangeToRight();
        }
        public void ChangeToLeft()
        {
            state.ChangeToLeft();
        }
        public void ChangeToUp()
        {
            state.ChangeToUp();
        }
        public void ChangeToDown()
        {
            state.ChangeToDown();
        }
        public void GetDamage()
        {
            state.GetDamage();
        }
        public void Attack()
        {
            state.Attack();
        }



    }
}

