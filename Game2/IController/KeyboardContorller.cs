
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

            map.Add(Keys.Up, new ChangeToUpCommand(myGame));
            map.Add(Keys.Left, new ChangeToLeftCommand(myGame));
            map.Add(Keys.Right, new ChangeToRightCommand(myGame)); ;
            map.Add(Keys.Down, new ChangeToDownCommand(myGame));

            map.Add(Keys.E, new GetDamagedCommand(myGame));
            map.Add(Keys.Z, new AttackCommand(myGame));
            map.Add(Keys.N, new AttackCommand(myGame));
          

            map.Add(Keys.U, new PreviousItemCommand(myGame));
            map.Add(Keys.I, new NextItemCommand(myGame));

            map.Add(Keys.D1, new Gear1(myGame));
            map.Add(Keys.D2, new Gear2(myGame));
            map.Add(Keys.D3, new Gear3(myGame)); 
            map.Add(Keys.D4, new Gear4(myGame)); 
            map.Add(Keys.D5, new Gear5(myGame)); 
            //map.Add(Keys.D0, new Gear0(myGame)); 


           
            map.Add(Keys.R, new ResetState(myGame));
            map.Add(Keys.Q, new QuitCommand(myGame));
        }
        public void Update()
        {
            newState = Keyboard.GetState();
            Keys[] newPressedKeys =  newState.GetPressedKeys();
            Keys[] oldPressedKeys = { };
            Keys[] pressedKeys = newState.GetPressedKeys();

            if (oldState != null)
            {
                oldPressedKeys = oldState.GetPressedKeys();
            }

          
            if (newPressedKeys.Length > oldPressedKeys.Length)
            {
                pressedKeys=newPressedKeys.Where(x => ! oldPressedKeys.Contains(x)).ToArray();
              
            }

            if (newState != oldState)
            {
                foreach (Keys key in pressedKeys)
                {
                    if (map.ContainsKey(key))
                    { 
                        map[key].Execute();
                    }
                }
            }
             
            oldState = newState;


            //link can walk only when key (A,W,D,S) is pressed
             if (Keyboard.GetState().IsKeyDown(Keys.A) || Keyboard.GetState().IsKeyDown(Keys.W) || Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.S) ||
                Keyboard.GetState().IsKeyDown(Keys.Up) || Keyboard.GetState().IsKeyDown(Keys.Down) || Keyboard.GetState().IsKeyDown(Keys.Left) || Keyboard.GetState().IsKeyDown(Keys.Right))
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




