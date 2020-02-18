using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 { 
    class QuitCommand : ICommand
    {
        private Game myGame;
        public QuitCommand(Game game)
        {
            myGame = game;
        }

        public void Execute() {
            myGame.Exit();
        }
    }
}
