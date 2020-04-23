using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class WallMasterRightDynamicState : IEnemyState
    {
        private WallMaster wallMaster;
        private Texture2D texture = Texture2DStorage.GetEnemySpriteSheet2();
        public WallMasterRightDynamicState(WallMaster w)
        {
            if (w == null)
            {
                throw new System.ArgumentNullException(nameof(w));
            }
            this.wallMaster = w;
            wallMaster.WallMasterSprite = new WallMaterMoveRightSprite(texture,wallMaster);
        }
        public void ChangeToRightStatic()
        {
            wallMaster.state = new WallMasterRightStaticState(wallMaster);
        }

        public void ChangeToLeftStatic()
        {
            wallMaster.state = new WallMasterLeftDynamicState(wallMaster);
        }

        public static void ChangeToRightDynamic()
        {
            
        }

        public void ChangeToLeftDynamic()
        {
            wallMaster.state = new WallMasterLeftDynamicState(wallMaster);
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
