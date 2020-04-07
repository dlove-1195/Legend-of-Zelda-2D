﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class GreenDragonWalkRightState : IEnemyState
    {
        private GreenDragon greenDragon;
        private Texture2D texture = Texture2DStorage.GetEnemySpriteSheet();
        public GreenDragonWalkRightState(GreenDragon dragon)
        {
            if (dragon == null)
            {
                throw new ArgumentNullException(nameof(dragon));
            }
            this.greenDragon = dragon;
            greenDragon.GreenDragonSprite = new GreenDragonWalkRightSprite(texture, greenDragon);
            greenDragon.fire = new Fire(greenDragon.posX - 30, greenDragon.posY, 2);
            GreenDragon.hasFire = true;
        }
        public void ChangeToRight()
        {
            //already right
        }

        public void ChangeToLeft()
        {
            greenDragon.state = new GreenDragonWalkLeftState(greenDragon);
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
