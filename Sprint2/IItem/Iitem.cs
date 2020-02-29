using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
namespace Sprint2
{
    public interface Iitem
    {
        void nextItem(Game1 myGame);
        void preItem(Game1 myGame);
       
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
