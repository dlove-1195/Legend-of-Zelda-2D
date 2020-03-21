using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class ChangeToRightCommand : ICommand
    {
        private Game1 myGame;
        public ChangeToRightCommand(Game1 game)
        {
            myGame = game;
        }
        public void Execute()
        {
            myGame.player.ChangeToRight(); 
        }
    }
}
