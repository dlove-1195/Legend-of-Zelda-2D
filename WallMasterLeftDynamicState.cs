using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class WallMasterLeftDynamicState : IEnemyState
    {
        private WallMaster wallMaster;
        private Texture2D texture = Texture2DStorage.GetEnemySpriteSheet2();
        public WallMasterLeftDynamicState(WallMaster w)
        {

            this.wallMaster = w;
            wallMaster.WallMasterSprite = new WallMasterLeftClose(texture);
        }
        public void ChangeToRightStatic()
        {
            wallMaster.state = new WallMasterRightStaticState(wallMaster);
        }

        public void ChangeToLeftStatic()
        {
            wallMaster.state = new WallMasterLeftStaticState(wallMaster);
        }

        public void ChangeToRightDynamic()
        {
            wallMaster.state = new WallMasterRightDynamicState(wallMaster);
        }

        public void ChangeToLeftDynamic()
        {
            
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
