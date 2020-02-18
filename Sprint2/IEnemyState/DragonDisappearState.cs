using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class DragonDisappearState: IEnemyState
    {
        private Dragon dragon;
        private Texture2D texture = Texture2DStorage.GetEnemySpriteSheet();
        public DragonDisappearState(Dragon dragon)
        {
            this.dragon = dragon;
            dragon.DragonSprite = new DragonWalkUpSprite();
        }
        public void ChangeToAppear()
        {
            dragon.state = new DragonWalkDownState(dragon);
        }
        public void ChangeToDisappear()
        {
            //already disappear, do nothing
        }
        public void ChangeToRight()
        {
            dragon.state = new DragonWalkRightState(dragon);
        }

        public void ChangeToLeft()
        {
            dragon.state = new DragonWalkLeftState(dragon);
        }

        public void ChangeToUp()
        {
            dragon.state = new DragonWalkUpState(dragon);
        }

        public void ChangeToDown()
        {
            dragon.state = new DragonWalkDownState(dragon);
        }
    }
}
