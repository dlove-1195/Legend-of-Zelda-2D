﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class DragonWalkRightState : IEnemyState
    {
        private Dragon dragon;
        private Texture2D texture = Texture2DStorage.GetEnemySpriteSheet();
        public DragonWalkRightState(Dragon dragon)
        {

            this.dragon = dragon;
            dragon.DragonSprite = new DragonWalkRightSprite(texture);
            dragon.fire = new Fire(Dragon.posX+80, Dragon.posY , 3);
        }
        public void ChangeToRight()
        {
            //already right
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
