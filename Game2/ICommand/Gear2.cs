using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint2 
{
    class Gear2: ICommand
    {
        private Game1 myGame;
        public Gear2(Game1 game)
        {
            myGame = game;
        }
        public void Execute()
        {
            Vector2 position = myGame.player.GetPosition();
            int x = (int)position.X;
            int y = (int)position.Y;
           
            myGame.player.LinkWithItemRightState(new Bomb(x, y));
        }
    }
}
