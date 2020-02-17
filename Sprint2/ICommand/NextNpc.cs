using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    class NextNpc: ICommand
    {
        private Game1 myGame;
        public NextNpc(Game1 game)
        {
            myGame = game;
        }
        public void Execute()
        {
            myGame.enemy.nextNpc(myGame);
        }
    }
}
