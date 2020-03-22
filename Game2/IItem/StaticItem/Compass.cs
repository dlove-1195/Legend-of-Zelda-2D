using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Compass : Iitem
    {
        public int count { get; set; } = 0;
        public int totalCount { get; set; } = 100;
        public bool appear { get; set; } = false;
        private int p = 8;
        //Sprite class parameter
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private int sourceLocX = 82;
        private int sourceLocY = 42;
        private int width = 11;
        private int height = 12;

        public Rectangle boundingBox { get; set; }


        //Sprite Object
        private ISprite compassSprite;

        //initial position on the ground
        public int posX { get; set; }
        public int posY { get; set; }


        public Compass(Vector2 vector)
        {
            posX = (int)vector.X;
            posY = (int)vector.Y;
            compassSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

        }


        public void Draw(SpriteBatch spriteBatch)
        {
            compassSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
            compassSprite.Update();
        }

        public int getItem()
        {
            return p;
        }
        public static void changeState()
        {
            //do nothing
        }

        public void changeSprite(ISprite sprite)
        {
            //do nothing
        }

        public void nextItem(Game1 myGame)
        {


           // myGame.item = new Fairy();
        }

        public void preItem(Game1 myGame)
        {

         //   myGame.item = new Clock();
        }
    }
}
