
using Microsoft.Xna.Framework.Input; 
using System.Collections.Generic;
using System.Linq;
 

namespace Sprint2
{
    public class PauseStateController : IController
    {
        private Dictionary<Keys, ICommand> map;
        
        private Game1 myGame;
        public PauseStateController(Game1 game )  {
            
            myGame = game;
            map = new Dictionary<Keys, ICommand>();

            map.Add(Keys.Q, new QuitCommand(myGame));
            map.Add(Keys.R, new  SwitchToPlayCommand(myGame));
             
        }
        public void Update()
        {
            Keys[] pressedKeys= Keyboard.GetState().GetPressedKeys();
            foreach (Keys key in pressedKeys)
            {
                if (map.ContainsKey(key))
                {
                    map[key].Execute();
                }
            }
            /*newState = Keyboard.GetState();
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

 
    */
        }
    }
}




