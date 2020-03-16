using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace Sprint2
{
    public class Heart : Iitem
    {
        private int p = 10;
        //Sprite parameter
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        private int sourceLocX = 244;
        private int sourceLocY = 199;
        private int width = 7;
        private int height = 8;

        public Rectangle boundingBox { get; set; }


        //Sprite Object
        public ISprite heartSprite;

        //initial position in the center
        public int posX;
        public int posY;

        public Heart(Vector2 vector)
        {
            posX = (int)vector.X;
            posY = (int)vector.Y;
            heartSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            heartSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
            heartSprite.Update();
        }
        public int getItem()
        {
            return p;
        }
        public void changeState(IitemState state)
        {
            //do nothing
        }

        public void changeSprite(ISprite sprite)
        {
            //do nothing
        }
        public void preItem(Game1 myGame)
        {

          //  myGame.item = new Fairy();

        }
        public void nextItem(Game1 myGame)
        {

            //myGame.item = new HeartContainer();

        }
    }
}
