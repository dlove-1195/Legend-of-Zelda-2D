using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class DragonWalkDownState: IEnemyState
    {

        private Dragon dragon;
        private Texture2D texture = Texture2DStorage.GetEnemySpriteSheet();
        public DragonWalkDownState(Dragon dragon)
        {

            this.dragon = dragon;
            dragon.DragonSprite = new DragonWalkDownSprite(texture);

            dragon.fire = new Fire(Dragon.posX, Dragon.posY+60, 1);
            Dragon.hasFire = true;
            
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
            // already down 
        }
     
    }
}
