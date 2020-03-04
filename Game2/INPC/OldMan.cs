using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{
    public class OldMan : Inpc
    {


        public ISprite OldManSprite;
        private Texture2D texture = Texture2DStorage.GetNpcSpriteSheet();
        public OldMan()
        {

            //initial sprite
            OldManSprite = new StaticSprite(texture, 0, 5, 16, 16);
        }




        public void Update()
        {
            OldManSprite.Update();


        }

        public void Draw(SpriteBatch spriteBatch)
        {
            OldManSprite.Draw(spriteBatch, new Vector2(400, 120));
        }


        public void previousNPC(Game1 game)
        {

        }
        public void nextNPC(Game1 game)
        {

        }



    }
}
