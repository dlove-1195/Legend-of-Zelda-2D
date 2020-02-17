using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> map;
        private KeyboardState oldState;
        private KeyboardState newState;
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

            map.Add(Keys.E, new GetDamagedCommand(myGame));
            map.Add(Keys.Z, new AttackCommand(myGame));
            map.Add(Keys.N, new AttackCommand(myGame));
            /* need to add a super attack with a different button??
              */

            map.Add(Keys.U, new PreviousItemCommand(myGame));
            map.Add(Keys.I, new NextItemCommand(myGame));

<<<<<<< HEAD
             map.Add(Keys.D1, new Gear1(myGame));
             map.Add(Keys.D2, new Gear2(myGame));
            /* map.Add(Keys.D3, new Gear3(myGame));*/
              map.Add(Keys.O, new PreviousEnemy(myGame));
             map.Add(Keys.P, new NextNpc(myGame));
             map.Add(Keys.R, new ResetState(myGame)); 
=======
            map.Add(Keys.D1, new Gear1(myGame));
            map.Add(Keys.D2, new Gear2(myGame));
            /* map.Add(Keys.D3, new Gear3(myGame));
              map.Add(Keys.O, new PreviousEnemy(myGame));
             map.Add(Keys.P, new NextEnemy(myGame));*/
            map.Add(Keys.R, new ResetState(myGame));
>>>>>>> ba55c543995b85dd56b6950a590507da5c4f25a7
            map.Add(Keys.Q, new QuitCommand(myGame));
        }
        public void Update()
        {
            newState = Keyboard.GetState();
            Keys[] pressedKeys = newState.GetPressedKeys();

            if ((oldState.IsKeyUp(Keys.U) && newState.IsKeyDown(Keys.U)) || (oldState.IsKeyUp(Keys.I) && newState.IsKeyDown(Keys.I)))
            {
                if (newState.IsKeyDown(Keys.U))
                    map[Keys.U].Execute();
                if (newState.IsKeyDown(Keys.I))
                    map[Keys.I].Execute();

            }
            oldState = newState;
            foreach (Keys key in pressedKeys)
            {


                if (key.Equals(Keys.U) || key.Equals(Keys.I))
                {
                }
                else if (map.ContainsKey(key))
                {


                    map[key].Execute();
                }


            }
            //link can walk only when key (A,W,D,S) is pressed
            if (Keyboard.GetState().IsKeyDown(Keys.A) || Keyboard.GetState().IsKeyDown(Keys.W) || Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.S))
            {
                i = new ChangeToWalkCommand(myGame);


            }

            else
            {
                i = new ChangeToStandCommand(myGame);

            }

            i.Execute();




        }
    }
}



