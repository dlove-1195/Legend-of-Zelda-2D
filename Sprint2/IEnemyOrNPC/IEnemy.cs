using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public interface IEnemyOrNPC
    {
        void ChangeToLeft();
        void ChangeToRight();
        void ChangeToUp();
        void ChangeToDown();
        

        
        void Update();
        void Draw(SpriteBatch spriteBatch);

        void previousEnemy(Game1 game);
        void nextEnemy(Game1 game);



    }
}
