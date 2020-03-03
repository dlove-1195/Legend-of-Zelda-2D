﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    class Gear4 : ICommand
    {
        private Game1 myGame;
        public Gear4(Game1 game)
        {
            myGame = game;
        }
        public void Execute()
        {

            Vector2 position = myGame.player.GetPosition();
            int x = (int)position.X;
            int y = (int)position.Y;
           
           
            
                myGame.player.LinkWithItemRightState(new BlueCandle(x, y,3));
            
        }
    }
}
