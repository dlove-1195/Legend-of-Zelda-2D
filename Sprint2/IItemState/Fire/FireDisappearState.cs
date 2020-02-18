using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class FireDisappearState : IitemState
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

       
    }
}
