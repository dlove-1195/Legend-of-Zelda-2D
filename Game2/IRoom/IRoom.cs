using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public interface IRoom
    {
        Vector2 roomSize { get; set; }

        Iplayer player { get; set; }
        List <IEnemy>enemies { get; set; }
        List <Iitem> pickUpItems { get; set; }
        List <Inpc> npcs { get; set; }
        List <KeyValuePair<int, int>> blockLocation { get; set; }
        List<KeyValuePair<string, Vector2>> doorLocation { get; set; }
        //add door collisoin detecter and door collision handler to construct new room??
        //can use block detector for door collision detect
        void setItemToNull(int itemNum);
        void setEnemyToNull(int enemyNum);      
        void Update();

        void Draw(SpriteBatch spriteBatch);
    }
}
