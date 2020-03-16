using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface ILevel
    {
          IRoom room { get; set; }
        void switchRoom(string direction);
        void Update();
        void Draw(SpriteBatch spriteBatch);
        int getNextRoomNum(string direction);
    }
}
