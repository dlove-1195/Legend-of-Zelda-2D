using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class DragonWalkUpState: IEnemyState
    {
        private Dragon dragon;
        private Texture2D texture = Texture2DStorage.GetEnemySpriteSheet();
        public DragonWalkUpState(Dragon dragon)
        {

            this.dragon = dragon;
            dragon.DragonSprite = new DragonWalkUpSprite(texture);
           dragon.fire = new Fire(Dragon.posX, Dragon.posY-40 , 0);
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
            //already up
        }

        public void ChangeToDown()
        {
            dragon.state = new DragonWalkDownState(dragon);
        }

        public void ChangeToAppear()
        {
            //do nothing, already appear 
        }
        public void ChangeToDisappear()
        {
            dragon.state = new DragonDisappearState(dragon);
        }
    }
}
