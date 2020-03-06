using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{
    public class Merchant : Inpc
    {


        public ISprite MerchantSprite;
        private Texture2D texture = Texture2DStorage.GetNpcSpriteSheet();

        //----for detection class --- start
        public int posY;
        public int posX;
        private int merchantWidth = 14;//sprite width
        private int merchantHeight = 16;//sprite height

        public Rectangle boundingBox { get; set; }
        // ---  end ---
        public Merchant(Vector2 vector)
        {
            vector.X = posX;
            vector.Y = posY;
            //initial sprite
            MerchantSprite = new StaticSprite(texture, 61, 5, 14, 16);//14= merchantWidth, 16=merchantHeight
        }




        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, merchantWidth * 3, merchantHeight * 3);
            MerchantSprite.Update();


        }

        public void Draw(SpriteBatch spriteBatch)
        {
            MerchantSprite.Draw(spriteBatch, new Vector2(400, 120));
        }


        public void previousNPC(Game1 game)
        {

        }
        public void nextNPC(Game1 game)
        {

        }



    }
}
