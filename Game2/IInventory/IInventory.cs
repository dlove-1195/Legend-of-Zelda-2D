using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public interface IInventory
    {
        int heartNum { get; set; }
        int diamondNum{ get; set; }
        int keyNum { get; set; }
        int bombNum { get; set; }

        /*Vector2 heartPos { get; set; }
        Vector2 diamondPos { get; set; }
        Vector2 keyPos { get; set; }
        Vector2 bombPos { get; set; }*/

        IItem itemA { get; set; }
        IItem itemB { get; set; }

        void Update();
        void Draw(SpriteBatch spriteBatch);

    }
}
