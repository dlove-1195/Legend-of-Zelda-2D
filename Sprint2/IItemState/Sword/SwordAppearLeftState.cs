using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class SwordAppearLeftState : IitemState
    {
        private Sword sword;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
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
        
    }
}
