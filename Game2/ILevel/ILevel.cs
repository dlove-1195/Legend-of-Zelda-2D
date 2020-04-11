using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public interface ILevel
    {
        bool roomUpdate { get; set; }
        IRoom room { get; set; }
        void switchRoom(string direction);
        void switchUnderground(Vector2 destRoomPos, string direction);
        void Update();
        void Draw(SpriteBatch spriteBatch);
        int getNextRoomNum(string direction);
        List<IRoom> existingRooms { get; set; }
    }
}
