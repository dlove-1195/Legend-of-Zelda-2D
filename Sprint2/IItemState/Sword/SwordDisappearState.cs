using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class SwordDisappearState : IitemState
    {
        private Sword sword;
        public SwordDisappearState(Sword sword)
        {
            this.sword = sword;
            sword.swordSprite = new WoodenSwordDown();//error missing sword disappear sprite
        }
        public void ChangeToAppear()
        {
            sword.state = new SwordAppearRightState(sword);
        }

        public void ChangeToDisappear()
        {
            //already disappear, do nothing
        }

      
    }
}
