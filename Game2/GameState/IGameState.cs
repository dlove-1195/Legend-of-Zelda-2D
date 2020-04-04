using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{

 
    interface IGameState
    {
        void Update();
        void Draw(SpriteBatch spriteBatch);
       //add later when we have controller
        //void ChangeState();
    }
}
