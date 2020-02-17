using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class FireAppearUpState : IitemState
    {
        private Fire fire;
        private Texture2D texture = Texture2DStorage.GetEnemySpriteSheet2();

        public FireAppearUpState(Fire fire)
        {
            this.fire = fire;
            fire.fireSprite = new ItemFireballMoveUpSprite(texture);//error missing up sprite
        }
        public void ChangeToAppear()
        {
            //already appear, do nothing
        }

        public void ChangeToDisappear()
        {
            fire.state = new FireDisappearState(fire);
        }
        
    }
}
