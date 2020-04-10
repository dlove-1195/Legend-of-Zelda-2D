
using Microsoft.Xna.Framework.Input; 
using System.Collections.Generic;
 

namespace Sprint2
{
    public class InventoryController : IController
    {
       // private Dictionary<Keys, ICommand> map;
      
        private Game1 myGame;
       
        private ICommand command;
        public InventoryController(Game1 game )
        {
            myGame = game;
        }
        public void Update()
        {
            IInventory inventory = myGame.playState.inventoryBar;
            InventoryDetector(inventory);
            if (command != null)
            {
                command.Execute();
            }

        }

        public void InventoryDetector(IInventory inventory)
        {
             
            if (inventory.heartNum <= 0)
            {
                command = new SwitchToLoseCommand(myGame);
            }
            else if (inventory.triPieceNum >= 3)
            {
                command = new SwitchToWinCommand(myGame);
            }
        }
    }
}




