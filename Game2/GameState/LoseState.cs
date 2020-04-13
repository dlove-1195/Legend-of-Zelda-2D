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
<<<<<<< HEAD
            LetterGenerator.drawSentence(spriteBatch, "YOU DIE", new Vector2(300, 200), new Vector2(25, 25));
            LetterGenerator.drawSentence(spriteBatch, "PRESS R TO RESTART", new Vector2(250, 500), new Vector2(18, 18));
            LetterGenerator.drawSentence(spriteBatch, "PRESS ESC TO QUIT", new Vector2(250, 550), new Vector2(18, 18));
=======
            Rectangle sourceRectangle = new Rectangle(23, 0, 600, 300);
            Rectangle destinationRectangle = new Rectangle(0, 200, 800, 400);
#pragma warning disable CA1062 // Validate arguments of public methods
            spriteBatch.Draw(LoseTexture, destinationRectangle, sourceRectangle,Color.White);
#pragma warning restore CA1062 // Validate arguments of public methods
>>>>>>> e46cf5177f387ad6c53115136a811ba2a9abf744
        }

    }
}
