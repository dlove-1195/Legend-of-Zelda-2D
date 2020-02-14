using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public interface IEnemy
    {
        void ChangeToLeft();
        void ChangeToRight();
        void ChangeToUp();
        void ChangeToDown();

        
        void Update();
        void Draw(SpriteBatch spriteBatch);

        void RandomStateGenerator();

        Vector2 GetPosition();
        void SetPosition(int posX, int posY);
    }
}
