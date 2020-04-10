using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public interface IInventory
    {
        bool barOnly { get; set; }  
        int heartNum { get; set; }
        int diamondNum{ get; set; }
        int keyNum { get; set; }
        int bombNum { get; set; }
        int triPieceNum { get; set; }

        string itemA { get; set; }
        string itemB { get; set; }
         List<String> itemList { get; set; }
        int currentIndex { get; set; }
        string itemSelect { get; set; }
        void Update();
        void Draw(SpriteBatch spriteBatch);

    }
}
