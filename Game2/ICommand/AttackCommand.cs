using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class AttackCommand: ICommand
    {
        private Game1 myGame;
        public AttackCommand(Game1 game)
        {
            myGame = game;
        }
        public void Execute()
        {
            myGame.player.Attack(); 
        }
    }
}
