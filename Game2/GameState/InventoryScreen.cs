using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
   public class InventoryScreen : IGameState
    {
        private Texture2D backTexture = Texture2DStorage.GetInventorySpriteSheet();
        private Texture2D inventoryTexture = Texture2DStorage.GetNumberSpriteSheet();
        private IController inventoryStateController;
        private Viewport barViewport;
        private Viewport topViewport;


        public IInventory inventoryBar { get; set; }
        public string name { get; set; }


        private static int width = 800;
        private static int height = 200;
        private Vector2 heartPos = new Vector2(width - 213, height - 94);


        public InventoryScreen(Game1 game) {
            name = "inventory";
            inventoryStateController = new InventoryStateController(game);
            inventoryBar = game.playState.inventoryBar;
        }
        public void Update() {
            inventoryStateController.Update();
            inventoryBar.Update();
            
        }
        public void Draw(SpriteBatch spriteBatch) {

            //draw background
            Rectangle sourceRectangle1 = new Rectangle(0, 71, 800, 800);
            Rectangle destinationRectangle = new Rectangle(0, 0, Game1.WindowWidth, Game1.WindowHeight);
            spriteBatch.Draw(backTexture, destinationRectangle, sourceRectangle1, Color.White);



          topViewport = new Viewport(new Rectangle(0, 0, Game1.WindowWidth, 600));

            barViewport = new Viewport(new Rectangle(0, Game1.WindowHeight *3/ 4, Game1.WindowWidth, 200));
            inventoryBar.Draw(spriteBatch,600);

        }




    }
}
