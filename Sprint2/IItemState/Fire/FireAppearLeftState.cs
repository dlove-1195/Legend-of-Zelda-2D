using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class FireAppearLeftState : IMovingitemstate
    {
        private Fire fire;
        private Texture2D texture = Texture2DStorage.GetEnemySpriteSheet2();

        public FireAppearLeftState(Fire fire)
        {
            this.fire = fire;
            fire.fireSprite = new ItemFireballMoveLeftSprite(texture);//error missing fire left sprite
        }
        public void ChangeToAppear()
        {
            //already appear
        }

        public void ChangeToDisappear()
        {
            fire.state = new FireDisappearState(fire);
        }
        public void ChangeToDown()
        {
            fire.state = new FireAppearDownState(fire);
        }
        public void ChangeToUp()
        {
            fire.state = new FireAppearUpState(fire);
        }
        public void ChangeToRight()
        {
            fire.state = new FireAppearRightState(fire);
        }

        public void ChangeToLeft()
        {
          
        }
    }
}
