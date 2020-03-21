using Microsoft.Xna.Framework.Graphics;
 

namespace Sprint2
{
    public class WallMasterLeftDynamicState : IEnemyState
    {
        private WallMaster wallMaster;
        private Texture2D texture = Texture2DStorage.GetEnemySpriteSheet2();
        public WallMasterLeftDynamicState(WallMaster w)
        {

            this.wallMaster = w;
            wallMaster.WallMasterSprite = new WallMaterMoveLeftSprite(texture,wallMaster);
        }
        public void ChangeToRight ()
        {
            wallMaster.state = new WallMasterRightStaticState(wallMaster);
        }

        public void ChangeToLeft ()
        {
            wallMaster.state = new WallMasterLeftStaticState(wallMaster);
        }

         
        public void ChangeToUp()
        {
        }

        public void ChangeToDown()
        {
        }
    }
}
