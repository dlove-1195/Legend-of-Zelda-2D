using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    class ResetState: ICommand
    {
        private Game1 myGame;
        public ResetState(Game1 game)
        {
            myGame = game;
        }
        public void Execute()
        {
           
            myGame.player.ChangeToRight();
            Link.posX = 200;
            Link.posY = 200;
           
            myGame.item = new Heart();
           
            myGame.enemy = new Dragon();
            Dragon.posX = 400;
            Dragon.posY = 200;

             
        }
    }
}
