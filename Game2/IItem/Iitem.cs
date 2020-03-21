using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Sprint2
{
    public interface Iitem
    {
        Rectangle boundingBox { get; set; }
         int posX { get; set; }
         int posY { get; set; }
         int count { get; set; }
         int totalCount { get; set; }
        bool appear { get; set; }

        void changeSprite(ISprite sprite);
        void nextItem(Game1 myGame);
        void preItem(Game1 myGame);
        int getItem();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
