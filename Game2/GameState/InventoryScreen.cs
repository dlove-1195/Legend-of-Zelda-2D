using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
   public class InventoryScreen : IGameState
    {
        private Texture2D inventoryTexture = Texture2DStorage.GetInventorySpriteSheet();
        private Texture2D boxTexture = Texture2DStorage.GetNumberSpriteSheet();
        private IController inventoryStateController;
        public string name { get; set; }
        public InventoryScreen(Game1 game) {
            name = "inventory";
        }
        public void Update() {
            
        }
        public void Draw(SpriteBatch spriteBatch) { }
    }
}
