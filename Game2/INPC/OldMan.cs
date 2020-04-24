using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{
    public class OldMan : INpc
    {


        private ISprite OldManSprite;
        private Texture2D texture = Texture2DStorage.GetNpcSpriteSheet();

        private int posY;
        private int posX;
        private int oldManWidth = 16;//sprite width
        private int oldManHeight = 16;//sprite height

        private bool ifTalk;

        public Rectangle boundingBox { get; set; }

        public OldMan(Vector2 vector)
        {
            posX = (int)vector.X;
            posY = (int)vector.Y;
            ifTalk = false;
            //initial sprite
            OldManSprite = new StaticSprite(texture, 0, 5, 16, 16);
        }




        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, oldManWidth * 3, oldManHeight * 3);
            OldManSprite.Update();


        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (ifTalk != true)
            {
                OldManSprite.Draw(spriteBatch, new Vector2(posX, posY));
            }
            else {
                OldManSprite.Draw(spriteBatch, new Vector2(posX, posY));
                LetterGenerator.drawSentence(spriteBatch, "GO SAVE THE PRINCESS", new Vector2(posX - 250, posY - 94), new Vector2(19, 19));
                LetterGenerator.drawSentence(spriteBatch, "YOUR JOURNEY BEGIN", new Vector2(posX - 200, posY - 72), new Vector2(19, 19));
            }
        }
        public void Talk() {
            ifTalk = true;
        }

        public void previousNPC(Game1 game)
        {

        }
        public void nextNPC(Game1 game)
        {

        }



    }
}
