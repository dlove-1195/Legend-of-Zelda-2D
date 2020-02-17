using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class DragonWalkLeftState: IEnemyState
    {
        private Dragon dragon;
        private Texture2D texture = Texture2DStorage.GetEnemySpriteSheet();
        public DragonWalkLeftState(Dragon dragon)
        {

            this.dragon = dragon;
            dragon.DragonSprite = new DragonWalkLeftSprite(texture);
            dragon.fire = new Fire(Dragon.posX-30, Dragon.posY, 2);
        }
        public void ChangeToRight()
        {
            dragon.state = new DragonWalkRightState(dragon);
        }

        public void ChangeToLeft()
        {
            //already left 
        }

        public void ChangeToUp()
        {
            dragon.state = new DragonWalkUpState(dragon);
        }

        public void ChangeToDown()
        {
            dragon.state = new DragonWalkDownState(dragon);
        }
        public void ChangeToAppear()
        {
            //already appear, do nothing
        }
        public void ChangeToDisappear()
        {
            dragon.state = new DragonDisappearState(dragon);
        }
    }
}
