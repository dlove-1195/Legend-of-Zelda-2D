using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{

    public class WinState : IGameState
    {

        //private Texture2D ButtonTexture = Texture2DStorage.GetButtonSpriteSheet();
        private Texture2D WinTriTexture = Texture2DStorage.GetTriForceSpriteSheet();
        private Texture2D BackgroundTexture = Texture2DStorage.GetBlackBackgroundSpriteSheet();
        private string sentence1 = "PRESS S TO RESTART GAME";
        private string sentence2 = "PRESS ESCAPE TO QUIT GAME";
        private string win = "YOU WIN";

        private Vector2 winLocation = new Vector2(300,350);
        private Vector2 sentence1Location = new Vector2(150, 390);
        private Vector2 sentence2Location = new Vector2(150, 430);
        private Vector2 fontSize = new Vector2(20,20);
        private int width = 140;
        private int height = 70;
        private int change = 0;
        private Vector2 triLoc = new Vector2(250, -70);
        private Game1 myGame;

        public IInventory inventoryBar { get; set; }
        private IController winStateController;
        public WinState(Game1 game)
        {
            Sound.PlayWin();
            winStateController = new WinStateController(game);
            myGame = game;
        }

        public void Update()
        {
            winStateController.Update();
            if (change <= 400)
            {
                change++;
            }
            if (change >= 400)
            {
                myGame.playState = null;
                if (triLoc.Y < 180 && width < 290 && height < 220)
                {
                    triLoc.Y++;

                    width++;
                    height++;


                }
            }




        }
        public void Draw(SpriteBatch spriteBatch)
        {
            
            //background
            Rectangle destinationBackRectangle1 = new Rectangle(-400 + change, (int)triLoc.Y, 400, 1000);
            Rectangle destinationBackRectangle2 = new Rectangle(800 - change, (int)triLoc.Y, 400, 1000);
            spriteBatch.Draw(BackgroundTexture, destinationBackRectangle1, Color.Black);
            spriteBatch.Draw(BackgroundTexture, destinationBackRectangle2, Color.Black);


            if (change >= 400)
            {
                /*
                //Restart button
                Rectangle sourceButtonRectangle1 = new Rectangle(478, 42, 92, 34);
                Rectangle destinationButtonRectangle1 = new Rectangle((int)button1Location.X, (int)button1Location.Y, 100, 55);
                spriteBatch.Draw(ButtonTexture, destinationButtonRectangle1, sourceButtonRectangle1, Color.White);

                //Exit button
                Rectangle sourceButtonRectangle2 = new Rectangle(477, 263, 92, 34);
                Rectangle destinationButtonRectangle2 = new Rectangle((int)button2Location.X, (int)button2Location.Y, 100, 55);
                spriteBatch.Draw(ButtonTexture, destinationButtonRectangle2, sourceButtonRectangle2, Color.White);
                */

                LetterGenerator.drawSentence(spriteBatch, win, winLocation, fontSize);
                LetterGenerator.drawSentence(spriteBatch, sentence1, sentence1Location, fontSize);
                LetterGenerator.drawSentence(spriteBatch, sentence2, sentence2Location, fontSize);


                //tri logo 
                Rectangle sourceTriRectangle = new Rectangle(30,40,800,501);
                Rectangle destinationTriRectangle = new Rectangle((int)triLoc.X, (int)triLoc.Y, width, height);
                spriteBatch.Draw(WinTriTexture, destinationTriRectangle, sourceTriRectangle, Color.White);

            }

        }
    }
}
