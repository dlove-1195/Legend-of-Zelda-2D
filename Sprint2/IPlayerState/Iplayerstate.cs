﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public interface Iplayerstate
    {
        void ChangeToRight();
        void ChangeToLeft();
        void ChangeToUp();
        void ChangeToDown();
        void GetDamaged();
        void Attack();
        void ChangeToWalk();
        void ChangeToStand();
        void LinkWithBomb();
        void LinkWithSword();
    }
}
