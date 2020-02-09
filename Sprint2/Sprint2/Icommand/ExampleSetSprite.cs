using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icommand
{
    class ExampleSetSprite : ICommand
    {
        private Game myGame;
        public ExampleSetSprite(Game game) {
            myGame = game;
        }
        public void Execute() {
            myGame.gameState = new ExampleGameState(myGame.State);// myGame.State?
        }
    }
}
