using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public interface INpc
    {
        void ChangeToLeft();
        void ChangeToRight();
        void ChangeToUp();
        void ChangeToDown();
        void previousEnemy(Game1 myGame);
        void Update();
        void Draw(SpriteBatch spriteBatch);

    }
}
