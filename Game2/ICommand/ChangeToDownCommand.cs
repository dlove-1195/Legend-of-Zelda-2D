﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class ChangeToDownCommand: ICommand
    {
        private Game1 myGame;
        public ChangeToDownCommand(Game1 game)
        {
            myGame = game;
        }
        public void Execute()
        {
            myGame.player.ChangeToDown(); 
        }
    }
}