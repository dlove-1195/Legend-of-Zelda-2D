using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class FireDisappearState : IMovingitemstate
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
            throw new NotImplementedException();
        }

        public void ChangeToLeft()
        {
            throw new NotImplementedException();
        }

        public void ChangeToRight()
        {
            throw new NotImplementedException();
        }

        public void ChangeToUp()
        {
            throw new NotImplementedException();
        }
    }
}
