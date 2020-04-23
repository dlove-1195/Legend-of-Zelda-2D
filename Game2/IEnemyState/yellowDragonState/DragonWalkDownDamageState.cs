﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
   public class DragonWalkDownDamageState: IEnemyState
    {
        private Dragon dragon;
        private Texture2D texture = Texture2DStorage.GetEnemySpriteSheet();
        public DragonWalkDownDamageState(Dragon dragon)
        {
            if (dragon == null)
            {
                throw new ArgumentNullException(nameof(dragon));
            }
            this.dragon = dragon;
            this.dragon.DragonSprite = new DragonWalkDownDamageSprite(texture, this.dragon);//nedd to fix later
            this.dragon.fire = new Fire(this.dragon.posX - 30, this.dragon.posY, 2);
            Dragon.hasFire = true;
            this.dragon.damage = true;
        }
        public void ChangeToRight()
        {
            if (dragon.damage)
            {
                dragon.state = new DragonWalkRightDamageState(dragon);
            }
            else
            {
                dragon.state = new DragonWalkRightState(dragon);
            }

        }

        public void ChangeToLeft()
        {
            if (dragon.damage)
            {
                dragon.state = new DragonWalkLeftDamageState(dragon);
            }
            else
            {
                dragon.state = new DragonWalkLeftState(dragon);
            }
        }

        public void ChangeToUp()
        {
            if (dragon.damage)
            {
                dragon.state = new DragonWalkUpDamageState(dragon);
            }
            else
            {
                dragon.state = new DragonWalkUpState(dragon);
            }
        }

        public void ChangeToDown()
        {
            if (dragon.damage)
            {
                dragon.state = new DragonWalkDownDamageState(dragon);
            }
            else
            {
                dragon.state = new DragonWalkDownState(dragon);
            }
        }
        public void GetDamaged()
        {
            //already damaged
        }
    }
}
