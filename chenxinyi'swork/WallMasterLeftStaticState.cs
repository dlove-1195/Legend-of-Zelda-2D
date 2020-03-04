﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class WallMasterLeftStaticState: IEnemyState
    {
        private WallMaster wallMaster;
        private Texture2D texture = Texture2DStorage.GetEnemySpriteSheet2();
        public WallMasterLeftStaticState(WallMaster w)
        {

            this.wallMaster = w;
            wallMaster.WallMasterSprite = new WallMasterLeftStatic(texture);
        }
        public void ChangeToRightStatic()
        {
            wallMaster.state = new WallMasterRightStaticState(wallMaster);
        }

        public void ChangeToLeftStatic()
        {
           
        }

        public void ChangeToRightDynamic()
        {
            wallMaster.state = new WallMasterRightDynamicState(wallMaster);
        }

        public void ChangeToLeftDynamic()
        {
            wallMaster.state = new WallMasterLeftDynamicState(wallMaster);
        }

        public void ChangeToAppear()
        {
            //do nothing, already appear 
        }
        public void ChangeToDisappear()
        {
            wallMaster.state = new WallMasterDisappearState(wallMaster);
        }

        public void ChangeToLeft()
        {
        }

        public void ChangeToRight()
        {
        }

        public void ChangeToUp()
        {
        }

        public void ChangeToDown()
        {
        }
    }
}