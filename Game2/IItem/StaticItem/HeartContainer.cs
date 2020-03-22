using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class HeartContainer : Iitem
    {
        public int count { get; set; } = 0;
        public int totalCount { get; set; } = 100;
        public bool appear { get; set; } = false;
        private int p = 11;
        //Sprite class parameter
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private int sourceLocX = 241;
        private int sourceLocY = 41;
        private int width = 13;
        private int height = 13;

        //Sprite Object
        private ISprite heartContainerSprite;
        public Rectangle boundingBox { get; set; }
        //initial position on the ground
        public int posX { get; set; }
        public int posY { get; set; }


        public HeartContainer(Vector2 vector)
        {
            posX = (int)vector.X;
            posY = (int)vector.Y;
            heartContainerSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

        }


        public void Draw(SpriteBatch spriteBatch)
        {
            heartContainerSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
            heartContainerSprite.Update();
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


           // myGame.item = new Key();
        }

        public void preItem(Game1 myGame)
        {

            //myGame.item = new Heart();
        }
    }
}
