using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public  class BombDisappearState : IBombitemstate
    {
        private Bomb bomb;
       
        public BombDisappearState(Bomb bomb)
        {
            this.bomb = bomb;
            bomb.bombSprite = new BombInitialSprite();
        }
        public void ChangeToAppear()
        {
            bomb.state = new BombAppearUnExplodeState(bomb);
        }

        public void ChangeToDisappear()
        {
            //already disappear, do nothing
        }

        public void ChangeToExplode()
        {
            //no explode
            
        }
    }
}
