using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class FireDisappearState : IMovingitemstate
    {
        private Fire fire;
        public FireDisappearState(Fire fire)
        {
            this.fire = fire;
            fire.fireSprite = new ItemFireballSprite();
            
        }

        public void ChangeToAppear()
        {
            fire.state = new FireAppearLeftState(fire);
                
        }

        public void ChangeToDisappear()
        {
            //already disappear, do nothing
        }

        public void ChangeToDown()
        {
            
        }

        public void ChangeToLeft()
        {
            
        }

        public void ChangeToRight()
        {
             
        }

        public void ChangeToUp()
        {
            
        }
    }
}
