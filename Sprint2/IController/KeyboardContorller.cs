﻿
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Sprint2
{
    public class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> map;

        private Game1 myGame;
        private ICommand i;
        public KeyboardController(Game1 game)
        {
            map = new Dictionary<Keys, ICommand>();
            
            myGame = game;
            map.Add(Keys.W, new ChangeToUpCommand(myGame));
            map.Add(Keys.A, new ChangeToLeftCommand(myGame));
            map.Add(Keys.D, new ChangeToRightCommand(myGame));
            map.Add(Keys.S, new ChangeToDownCommand(myGame));
           /* map.Add(Keys.E, new GetDemaged(myLink));
            map.Add(Keys.Z, new Attack(myLink));
            map.Add(Keys.N, new Attack(myLink)); */

           /* map.Add(Keys.D1, new gear1(myGame));
            map.Add(Keys.D2, new gear2(myGame));
            map.Add(Keys.D3, new gear3(myGame));
            map.Add(Keys.U, new previousItem(myGame));
            map.Add(Keys.I, new nextItem(myGame));
            map.Add(Keys.O, new previousEnemy(myGame));
            map.Add(Keys.P, new nextEnemy(myGame));
            map.Add(Keys.R, new resetState(myGame));*/
            map.Add(Keys.Q, new QuitCommand(myGame));  
        }
        public void Update()
        {
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();
            
            foreach (Keys key in pressedKeys) {
                map[key].Execute();
                
            }

            if (Keyboard.GetState().IsKeyDown(Keys.A) || Keyboard.GetState().IsKeyDown(Keys.W) || Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.S))
            {
                i = new ChangeToWalkCommand(myGame);
                i.Execute();
            }
            else
            {
                i = new ChangeToStandCommand(myGame);
                i.Execute();
            }

        }
    }
}
