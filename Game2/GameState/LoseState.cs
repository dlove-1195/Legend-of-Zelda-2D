using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class LoseState : IGameState

    {
        public String name {
            get;set;
        }
        public IInventory inventoryBar { get; set; }
        private Texture2D LoseTexture = Texture2DStorage.GetLoseSpriteSheet();
        private Texture2D cursor = Texture2DStorage.GetItemSpriteSheet();
        private IController loseStateController;
       // private int pointer;
        private Vector2 location;
        private Vector2 cursorLocation1 = new Vector2(100, 200);
        private Vector2 cursorLocation2 = new Vector2(100, 400);


        public LoseState(Game1 game) {
            name = "lose";
            loseStateController = new LoseStateController(game);
           // pointer = loseStateController.pointer;

        }
        public void Update() {
            loseStateController.Update();
            /*if (pointer == 1)
                location = cursorLocation1;
            else
                location = cursorLocation2;*/

        }
        public void Draw(SpriteBatch spriteBatch) {
            Rectangle sourceRectangle = new Rectangle(23, 0, 600, 300);
            Rectangle destinationRectangle = new Rectangle(0, 200, 800, 400);
            spriteBatch.Draw(LoseTexture, destinationRectangle, sourceRectangle,Color.White);
        }

    }
}
