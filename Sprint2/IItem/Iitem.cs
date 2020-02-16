using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
namespace Sprint2
{
    interface Iitem
    {
        void nextItem();
        void preItem();
        void Appear();
        void Disappear();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
