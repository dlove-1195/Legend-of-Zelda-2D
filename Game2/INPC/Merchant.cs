using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{
    public class Merchant : Inpc
    {


        public ISprite MerchantSprite;
        private Texture2D texture = Texture2DStorage.GetNpcSpriteSheet();
        public  Merchant()
        {

            //initial sprite
             MerchantSprite = new StaticSprite(texture, 61, 5, 14, 16);
        }




        public void Update()
        {
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
