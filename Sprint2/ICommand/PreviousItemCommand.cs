using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class PreviousItemCommand: ICommand
    {
        private Game1 myGame;
        public PreviousItemCommand(Game1 game)
        {
            myGame = game;
        }
        public void Execute()
        {
            myGame.item.preItem(myGame); 
        }
    }
}