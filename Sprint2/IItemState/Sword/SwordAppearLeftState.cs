using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class SwordAppearLeftState : IMovingitemstate
    {
        private Sword sword;
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        public SwordAppearLeftState(Sword sword)
        {
            this.sword = sword;
            sword.swordSprite = new WoodenSwordLeft(texture);//error missing swordLeft sprite
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
       
        public void ChangeToUp()
        {
            sword.state = new SwordAppearUpState(sword);
        }
        public void ChangeToDown()
        {
            sword.state = new SwordAppearDownState(sword);
        }

        public void ChangeToLeft()
        {
            //already left, do nothing
        }
    }
}
