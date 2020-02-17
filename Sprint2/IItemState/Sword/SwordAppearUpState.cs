using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class SwordAppearUpState : IMovingitemstate
    {
        private Sword sword;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        public SwordAppearUpState(Sword sword)
        {
            this.sword = sword;
            sword.swordSprite = new WoodenSwordUp(texture);//error missing sword disappear sprite
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
       
        public void ChangeToDown()
        {
            sword.state = new SwordAppearDownState(sword);
        }

        public void ChangeToUp()
        {
            //alraedy up, do nothing
        }
    }
}
