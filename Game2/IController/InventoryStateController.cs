using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Linq;


namespace Sprint2
{
    public class InventoryStateController : IController
    {
        private Dictionary<Keys, ICommand> map;

        private Game1 myGame;

        //  private int pointer { get; set; }
        //private List<int> scrollList = new List<int> { 1, 2 };
        public InventoryStateController(Game1 game)
        {

            myGame = game;
            map = new Dictionary<Keys, ICommand>();

            //  pointer = scrollList[0];
           map.Add(Keys.R, new SwitchToPlayCommand(myGame));
            // map.Add(Keys.Up, new PreviousInListCommand(myGame));
            // map.Add(Keys.Space, new SelectInListCommand(myGame));

        }
        public void Update()
        {
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();
            foreach (Keys key in pressedKeys)
            {
                if (map.ContainsKey(key))
                {
                    map[key].Execute();
                }
            }

        }
    }
}

