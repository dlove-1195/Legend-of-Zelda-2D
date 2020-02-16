using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    interface IMovingitemstate
    {
        void ChangeToDisappear();
        void ChangeToAppear();
        void ChangeToLeft();
        void ChangeToRight();
        void ChangeToDown();
        void ChangeToUp();
    }
}
