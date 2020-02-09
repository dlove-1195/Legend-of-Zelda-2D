using Icommand;
using Icontroller;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icontroller
{
    public class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> map;
        private Dictionary<Keys, ICommand> map2;
        private Link myGame;
        private ICommand i;
        public KeyboardController(Link game)
        {
            map = new Dictionary<Keys, ICommand>();
            map2 = new Dictionary<Keys, ICommand>();
            myGame = game;
            map2.Add(Keys.W, new ChangeToUp(myGame));
            map2.Add(Keys.A, new ChangeToLeft(myGame));
            map2.Add(Keys.D, new ChangeToRight(myGame));
            map2.Add(Keys.S, new ChangeToDown(myGame));
            map.Add(Keys.E, new GetDemage(myGame));
            map.Add(Keys.Z, new Attack(myGame));
            map.Add(Keys.N, new Attack(myGame));

            map.Add(Keys.D1, new gear1(myGame));
            map.Add(Keys.D2, new gear2(myGame));
            map.Add(Keys.D3, new gear3(myGame));
            map.Add(Keys.U, new previousItem(myGame));
            map.Add(Keys.I, new nextItem(myGame));
            map.Add(Keys.O, new previousEnemy(myGame));
            map.Add(Keys.P, new nextEnemy(myGame));
            map.Add(Keys.R, new resetState(myGame));
            map.Add(Keys.Q, new QuitCommand(myGame));
        }
        public void Update()
        {
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();
            
            foreach (Keys key in pressedKeys) {
                map[key].Execute();
                if (Keyboard.GetState().IsKeyDown(Keys.A) || Keyboard.GetState().IsKeyDown(Keys.W) || Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.S))
                {
                    i = new ChangeWalk(myGame);
                    i.Execute();
                }
                else {
                    i = new ChangeStand(myGame);
                    i.Execute();
                }
            }

        }
    }
}

