using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
   public class GetDamagedCommand: ICommand
    {
        private Game1 myGame;
        public GetDamagedCommand(Game1 game)
        {
            myGame = game;
        }
        public void Execute()
        {
            myGame.player.GetDamaged(); 
        }
    }
}
