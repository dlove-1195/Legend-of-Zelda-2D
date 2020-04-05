using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{

    public class PauseState : IGameState
    {



        //private Texture2D LinkTexture = Texture2DStorage.GetLinkSpriteSheet();
        public string name { get; set; }
        private Texture2D ButtonTexture = Texture2DStorage.GetButtonSpriteSheet();
        private Vector2 buttonLocation = new Vector2(300, 250);
        //Texture2D whiteRectangle;
        public PauseState()
        {
            name = "pause";

        }

        public void Update()
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            /*whiteRectangle = new Texture2D(spriteBatch.GraphicsDevice, 1, 1);
            whiteRectangle.SetData(new[] { Color.White });
            spriteBatch.Draw(whiteRectangle, new Rectangle(10, 20, 80, 30),
            Color.Chocolate); */
            // draw button
            Rectangle sourceButtonRectangle = new Rectangle(363, 42, 90, 35);
            Rectangle destinationButtonRectangle = new Rectangle((int)buttonLocation.X, (int)buttonLocation.Y, 200, 100);
            spriteBatch.Draw(ButtonTexture, destinationButtonRectangle, sourceButtonRectangle, Color.White);
        }
    }
}
