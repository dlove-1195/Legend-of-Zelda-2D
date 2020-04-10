using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
   public class InventoryScreen : IGameState
    {
        private Texture2D backTexture = Texture2DStorage.GetInventorySpriteSheet();
      
        private IController inventoryStateController;
        

        public IInventory inventory { get; set; }
        public string name { get; set; }
        private Game1 game;
       

        public InventoryScreen(Game1 game) {
            this.game = game; 
            inventory = game.playState.inventoryBar;
            inventoryStateController = new InventoryStateController(game, this);
        }
        public void Update() {
           // inventoryStateController = new InventoryStateController(game, this);
            inventoryStateController.Update();
            inventory.Update();
            
        }
        public void Draw(SpriteBatch spriteBatch) {

            //draw background
            Rectangle sourceRectangle1 = new Rectangle(0, 71, 800, 800);
            Rectangle destinationRectangle = new Rectangle(0, 0, Game1.WindowWidth, Game1.WindowHeight);
            spriteBatch.Draw(backTexture, destinationRectangle, sourceRectangle1, Color.White);
             
            inventory.barOnly = false;
            inventory.Draw(spriteBatch);
            

        }





    }
}
