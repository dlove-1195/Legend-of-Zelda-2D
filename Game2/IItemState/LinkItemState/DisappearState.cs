using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class DisappearState : IitemState
    {
        private Iitem linkItem;
        int num;
        public DisappearState(Iitem item)
        {
            this.linkItem = item;
            num = item.getItem();
          //////construct a new empty item sprites
            if (num == 0)
            {
                linkItem.changeSprite(new ArrowUp());
            }
            else if (num == 1)
            {
                linkItem.changeSprite(new BlueCandleUpRight());
            }
            else if (num == 2)
            {
                linkItem.changeSprite(new BombInitialSprite());
            }
            else if (num == 3)
            {
                linkItem.changeSprite(new BowUp());
            }
            else if (num == 4)
            {
                linkItem.changeSprite(new WoodenSwordUp());
            }
            else if (num == 5)
            {
                linkItem.changeSprite(new WoodBoomerangUp());
            }
            else if (num == 15)
            {
                linkItem.changeSprite(new ItemFireballMoveLeftSprite());
            }
        }
    
        public void ChangeToDisappear()
        {
            //do nothing
        }
    }
}
