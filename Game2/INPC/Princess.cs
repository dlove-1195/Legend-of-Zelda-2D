using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{
    public class Princess : Inpc
    {


        public ISprite PrincessSprite;
        private Texture2D texture = Texture2DStorage.GetNpcSpriteSheet();

        public int posY;
        public int posX;
        private int princessWidth = 14;//sprite width
        private int princessHeight = 26;//sprite height

        public Rectangle boundingBox { get; set; }
        public Princess(Vector2 vector)
        {
            vector.X = posX;
            vector.Y = posY;
            //initial sprite
            PrincessSprite = new StaticSprite(texture, 121, 5, 14, 26);
        }




        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, princessWidth * 3, princessHeight * 3);
            PrincessSprite.Update();


        }

        public void Draw(SpriteBatch spriteBatch)
        {
            PrincessSprite.Draw(spriteBatch, new Vector2(400, 120));
        }


        public void previousNPC(Game1 game)
        {

        }
        public void nextNPC(Game1 game)
        {

        }



    }
}
