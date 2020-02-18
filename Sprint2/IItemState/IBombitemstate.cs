using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public interface IBombitemstate
    {
        void ChangeToDisappear();
        void ChangeToAppear();
        void ChangeToExplode();
    }
}
