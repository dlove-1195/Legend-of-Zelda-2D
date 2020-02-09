using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iplayerstate
{
    interface Iplayerstate
    {
        void ChangeToRight();
        void ChangToLeft();
        void ChangeToUp();
        void ChangeToDown();
        void GetDamaged();
        void Attack();
    }
}
