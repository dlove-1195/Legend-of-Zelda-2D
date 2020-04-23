using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class WallMasterRightStaticState : IEnemyState
    {
        private WallMaster wallMaster;
        private Texture2D texture = Texture2DStorage.GetEnemySpriteSheet2();
        public WallMasterRightStaticState(WallMaster w)
        {
            if (w == null)
            {
                throw new System.ArgumentNullException(nameof(w));
            }
            this.wallMaster = w;
            wallMaster.WallMasterSprite = new WallMasterRightStatic(texture, wallMaster);
        }
        public void ChangeToRight ()
        {
            wallMaster.state = new WallMasterRightDynamicState(wallMaster);
        }

        public void ChangeToLeft ()
        {
            wallMaster.state = new WallMasterLeftDynamicState(wallMaster);
        }

         
        public void ChangeToUp()
        {
        }

        public void ChangeToDown()
        {
        }
        public void GetDamaged()
        {
            //
        }
    }
}
