using System;
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
       

        //delete
        // void LinkWithBomb();
        // void LinkWithSword();

        //add
        void LinkWithItemUp(Iitem item);
        void LinkWithItemDown(Iitem item);
        void LinkWithItemLeft(Iitem item);
        void LinkWithItemRight(Iitem item);
        //end
    }
}
