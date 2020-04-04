using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
 

namespace Sprint2 {

    public class WinState : IGameState
    {
        private Texture2D ButtonTexture = Texture2DStorage.GetButtonSpriteSheet();
        private Texture2D TriTexture = Texture2DStorage.GetItemSpriteSheet();

        private int change = 0;
        private Vector2 button1Location = new Vector2(200,260);
        private Vector2 button2Location = new Vector2(500,260);

        private Vector2 triTopLoc = new Vector2(20,30);
        private Vector2 triLeftLoc = new Vector2(0,300);
        private Vector2 triRightLoc = new Vector2(0,300);
        private Vector2 triLoc = new Vector2(400,300);

        public WinState()
        {
        }

        public void Update()
        {
            change++;




        }
        public void Draw(SpriteBatch spriteBatch)
        {
            //Restart button
            Rectangle sourceButtonRectangle1 = new Rectangle(478,42,92,34);
            Rectangle destinationButtonRectangle1 = new Rectangle((int)button1Location.X, (int)button1Location.Y, 100, 55);
            spriteBatch.Draw(ButtonTexture, destinationButtonRectangle1, sourceButtonRectangle1, Color.White);

            //Exit button
            Rectangle sourceButtonRectangle2 = new Rectangle(477, 263, 92, 34);
            Rectangle destinationButtonRectangle2 = new Rectangle((int)button2Location.X, (int)button2Location.Y, 100, 55);
            spriteBatch.Draw(ButtonTexture, destinationButtonRectangle2, sourceButtonRectangle2, Color.White);

            //top tri 
            Rectangle sourceTriRectangleTop = new Rectangle(343, 123, 10, 10);//106,10,43,45);
            Rectangle destinationTriRectangleTop = new Rectangle((int)triTopLoc.X, (int)triTopLoc.Y, 50, 50);
            spriteBatch.Draw(TriTexture, sourceTriRectangleTop, destinationTriRectangleTop, Color.White);

            //Left tri 
            Rectangle sourceTriRectangleLeft = new Rectangle(85,55,43,45);
            Rectangle destinationTriRectangleLeft = new Rectangle((int)triLeftLoc.X, (int)triLeftLoc.Y, 50, 50);
            spriteBatch.Draw(TriTexture, sourceTriRectangleLeft, destinationTriRectangleLeft, Color.White);

            //Right tri 
            Rectangle sourceTriRectangleRight = new Rectangle(128,55,43,45);
            Rectangle destinationTriRectangleRight = new Rectangle((int)triRightLoc.X, (int)triRightLoc.Y, 50, 50);
            spriteBatch.Draw(TriTexture, sourceTriRectangleRight, destinationTriRectangleRight, Color.White);

            //whole tri 
            Rectangle sourceTriRectangle = new Rectangle(81,11,87,89);
            Rectangle destinationTriRectangle = new Rectangle((int)triLoc.X, (int)triLoc.Y, 50, 50);
            spriteBatch.Draw(TriTexture, sourceTriRectangle, destinationTriRectangle, Color.White);


        }
    }
}
