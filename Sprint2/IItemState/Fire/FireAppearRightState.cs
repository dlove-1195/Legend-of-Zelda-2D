using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class FireAppearRightState : IitemState
    {
        private Fire fire;
        private Texture2D texture = Texture2DStorage.GetEnemySpriteSheet2();

        public FireAppearRightState(Fire fire)
        {
            this.fire = fire;
            fire.fireSprite = new ItemFireballMoveRightSprite(texture);//error missing fire right sprite
        }
        public void ChangeToAppear()
        {
            // already appear
        }

        public void ChangeToDisappear()
        {
            fire.state = new FireDisappearState(fire);
        }
       
    }
}
