using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class GreenDragonWalkLeftDamageState: IEnemyState
    {
        private GreenDragon greenDragon;
        private Texture2D texture = Texture2DStorage.GetHurtEnemySpriteSheet();
        public GreenDragonWalkLeftDamageState(GreenDragon dragon)
        {
            if (dragon == null)
            {
                throw new ArgumentNullException(nameof(dragon));
            }
            this.greenDragon = dragon;
            greenDragon.GreenDragonSprite = new GreenDragonDamageWalkLeftSprite(texture, greenDragon);
            greenDragon.fire = new Fire(greenDragon.posX-30, greenDragon.posY, 2);
            GreenDragon.hasFire = true;
        }
        public void ChangeToRight()
        {
            greenDragon.state = new GreenDragonWalkRightDamageState(greenDragon);
        }

        public void ChangeToLeft()
        {
            //already left 
        }

        public void ChangeToUp()
        {
            //none
        }

        public void ChangeToDown()
        {
            //none
        }
        
    }
}
