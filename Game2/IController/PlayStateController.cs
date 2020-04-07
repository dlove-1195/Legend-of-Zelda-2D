
using Microsoft.Xna.Framework.Input; 
using System.Collections.Generic;
using System.Linq;
 

namespace Sprint2
{
    public class PlayStateController : IController
    {
        private Dictionary<Keys, ICommand> map;
        private KeyboardState oldState;
        private KeyboardState newState; 
        private ICommand i;

        private PlayState myPlay;
        private Game1 myGame;
        public PlayStateController(Game1 game, PlayState play)
        {
            
            myPlay = play;
            myGame = game;
            map = new Dictionary<Keys, ICommand>();

             
            map.Add(Keys.W, new ChangeToUpCommand(myPlay));
            map.Add(Keys.A, new ChangeToLeftCommand(myPlay));
            map.Add(Keys.D, new ChangeToRightCommand(myPlay));
            map.Add(Keys.S, new ChangeToDownCommand(myPlay));

            map.Add(Keys.Up, new ChangeToUpCommand(myPlay));
            map.Add(Keys.Left, new ChangeToLeftCommand(myPlay));
            map.Add(Keys.Right, new ChangeToRightCommand(myPlay)); ;
            map.Add(Keys.Down, new ChangeToDownCommand(myPlay));

            map.Add(Keys.E, new GetDamagedCommand(myPlay));
            map.Add(Keys.Z, new AttackCommand(myPlay));
            map.Add(Keys.N, new AttackCommand(myPlay)); 
            map.Add(Keys.D1, new Gear1(myPlay));
            map.Add(Keys.D2, new Gear2(myPlay));
            map.Add(Keys.D3, new Gear3(myPlay)); 
            map.Add(Keys.D4, new Gear4(myPlay)); 
            map.Add(Keys.D5, new Gear5(myPlay)); 
          
         
            map.Add(Keys.Q, new QuitCommand(myGame));
            map.Add(Keys.P, new SwitchToPauseCommand(myGame));
            map.Add(Keys.Escape, new SwitchToLoseCommand(myGame));
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
                i = new ChangeToWalkCommand(myPlay);


            }

            else
            {
                i = new ChangeToStandCommand(myPlay);

            }

            i.Execute(); 




        }
    }
}




