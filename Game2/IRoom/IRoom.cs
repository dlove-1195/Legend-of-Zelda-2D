using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public interface IRoom
    {
        int leftRoomNum { get; set; }
        int rightRoomNum { get; set; }
        int upRoomNum { get; set; }
        int downRoomNum { get; set; }
         Vector2 roomPos { get; set; }

        List <IEnemy>enemies { get; set; }
        List <Iitem> pickUpItems { get; set; }
        List <Inpc> npcs { get; set; }
        List <KeyValuePair<int, int>> blockLocation { get; set; }
        List<KeyValuePair<int, int>> doorLocation { get; set; }
        List<KeyValuePair<int, int>> stairLocation { get; set; }
        List<Rectangle> boundingBox { get; set; }

        void setItemToNull(int itemNum);
        void setEnemyToNull(int enemyNum);
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
