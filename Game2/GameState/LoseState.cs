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
       
        private Texture2D LoseTexture = Texture2DStorage.GetLoseSpriteSheet();
        //private Texture2D cursor = Texture2DStorage.GetItemSpriteSheet();
        private IController loseStateController;
       


        public LoseState(Game1 game) {
          
            loseStateController = new LoseStateController(game);
            Sound.PlayLoseSong();
           

        }
        public void Update() {
            loseStateController.Update();
         
        }
        public void Draw(SpriteBatch spriteBatch) {
            Rectangle sourceRectangle = new Rectangle(23, 0, 600, 300);
            Rectangle destinationRectangle = new Rectangle(0, 200, 800, 400);
#pragma warning disable CA1062 // Validate arguments of public methods
            spriteBatch.Draw(LoseTexture, destinationRectangle, sourceRectangle,Color.White);
#pragma warning restore CA1062 // Validate arguments of public methods
        }

    }
}
