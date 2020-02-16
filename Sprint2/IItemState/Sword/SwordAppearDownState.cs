using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class SwordAppearDownState : IMovingitemstate
    {
        private Sword sword;
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();

        public SwordAppearDownState(Sword sword)
        {
            this.sword = sword;
            sword.swordSprite = new WoodenSwordDown(texture);//erro missing sword down sprite
        }
        public void ChangeToAppear()
        {
           //already appear, do nothing
        }

        public void ChangeToDisappear()
        {
            sword.state = new SwordDisappearState(sword);
        }
        public void ChangeToRight()
        {
            sword.state = new SwordAppearRightState(sword);
        }
        public void ChangeToLeft()
        {
            sword.state = new SwordAppearLeftState(sword);
        }
        public void ChangeToUp()
        {
            sword.state = new SwordAppearUpState(sword);
        }

        public void ChangeToDown()
        {
            //already down, do nothing
        }
    }
}
