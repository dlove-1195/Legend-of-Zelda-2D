using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    class Map: Iitem
    {
        public int count { get; set; } = 0;
        public int totalCount { get; set; } = 100;
        public bool appear { get; set; } = false;
        private int p = 13;
        //Sprite parameter
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private int sourceLocX = 244;
        private int sourceLocY = 80;
        private int width = 8;
        private int height = 16;
        public Rectangle boundingBox { get; set; }
        //Sprite Object
        public ISprite mapSprite;

        //initial position in the center
        public int posX { get; set; }
        public int posY { get; set; }

        public Map(Vector2 vector)
        {
            posX = (int)vector.X;
            posY = (int)vector.Y;
            mapSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            mapSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
            mapSprite.Update();
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

          //  myGame.item = new Key();

        }
        public void nextItem(Game1 myGame)
        {

            //myGame.item = new TriforcePiece();

        }
    }
}
