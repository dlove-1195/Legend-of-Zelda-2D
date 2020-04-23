using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{

    public class WinState : IGameState
    {
        private Texture2D ButtonTexture = Texture2DStorage.GetButtonSpriteSheet();
        private Texture2D WinTriTexture = Texture2DStorage.GetTriForceSpriteSheet();

        private Vector2 button1Location = new Vector2(200, 260);
        private Vector2 button2Location = new Vector2(500, 260);
        private int width = 140;
        private int height = 70;
        private Vector2 triLoc = new Vector2(250, -70);
        //add font "you win" later 
        public string name { get; set; }
        private IController winStateController;
        public WinState(Game1 game)
        {
            name = "win";
            winStateController = new WinStateController(game);
        }

        public void Update()
        {
            winStateController.Update();
            if (triLoc.Y < 180 && width < 290 && height < 220)
            {
                triLoc.Y++;

                width++;
                height++;


            }




        }
        public void Draw(SpriteBatch spriteBatch)
        {
            //Restart button
            Rectangle sourceButtonRectangle1 = new Rectangle(478, 42, 92, 34);
            Rectangle destinationButtonRectangle1 = new Rectangle((int)button1Location.X, (int)button1Location.Y, 100, 55);
            spriteBatch.Draw(ButtonTexture, destinationButtonRectangle1, sourceButtonRectangle1, Color.White);

            //Exit button
            Rectangle sourceButtonRectangle2 = new Rectangle(477, 263, 92, 34);
            Rectangle destinationButtonRectangle2 = new Rectangle((int)button2Location.X, (int)button2Location.Y, 100, 55);
            spriteBatch.Draw(ButtonTexture, destinationButtonRectangle2, sourceButtonRectangle2, Color.White);



            //tri logo 
            Rectangle destinationTriRectangle = new Rectangle((int)triLoc.X, (int)triLoc.Y, width, height);
            spriteBatch.Draw(WinTriTexture, destinationTriRectangle, Color.White);



        }
    }
}
