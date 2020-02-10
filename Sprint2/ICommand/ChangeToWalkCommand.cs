using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    class ChangeToWalkCommand: ICommand
    {
        private Game1 myGame;
        public ChangeToWalkCommand(Game1 game)
        {
            myGame = game;
        }
        public void Execute()
        {
            myGame.player.ChangeToWalk(); 
        }
    }
}
