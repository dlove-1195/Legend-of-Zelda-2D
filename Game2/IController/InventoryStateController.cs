using Microsoft.Xna.Framework.Input;
using System.Collections.Generic; 

namespace Sprint2
{
    public class InventoryStateController : IController
    {
        private Dictionary<Keys, ICommand> map;

        private Game1 myGame;
        private IInventory inventory;
        private KeyboardState oldState;
        private KeyboardState newState;
        public InventoryStateController(Game1 game, InventoryScreen inventoryScreen)
        {
            this.inventory = inventoryScreen.inventory;
            myGame = game;
            map = new Dictionary<Keys, ICommand>();
            map.Add(Keys.R, new SwitchToPlayCommand(myGame));
            //command for choosing item
            //later: need draw rectangle outside the item in inventory class
          
            map.Add(Keys.Up, new UpLineCommand(inventory));
            map.Add(Keys.Down, new DownLineCommand(inventory));
            map.Add(Keys.Right, new NextItemCommand(inventory));
            map.Add(Keys.Left, new PreviousItemCommand(inventory));
            map.Add(Keys.Enter, new SelectInListCommand(inventory)); 
             
            //command for map switching 
             

        }
        public void Update()
        {
            newState = Keyboard.GetState();
            Keys[] newPressedKeys = newState.GetPressedKeys();
            Keys[] oldPressedKeys = { };
            if (oldState != null)
            {
                oldPressedKeys = oldState.GetPressedKeys();
            }
            if (newState != oldState)
            {
                foreach (Keys key in newPressedKeys)
                {
                    if (map.ContainsKey(key))
                    {
                        map[key].Execute();
                    }
                }
            }
            oldState = newState;
        }
    }
}

