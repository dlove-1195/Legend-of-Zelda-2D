using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class HeartContainer : IItem
    {
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 100;
        public bool Appear { get; set; } = false;
        private int p = 11;
        //Sprite class parameter
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private int sourceLocX = 241;
        private int sourceLocY = 41;
        private int width = 13;
        private int height = 13;

        //Sprite Object
        private ISprite heartContainerSprite;
        public Rectangle BoundingBox { get; set; }
        //initial position on the ground
        public int PosX { get; set; }
        public int PosY { get; set; }


        public HeartContainer(Vector2 vector)
        {
            PosX = (int)vector.X;
            PosY = (int)vector.Y;
            heartContainerSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

        }


        public void Draw(SpriteBatch spriteBatch)
        {
            heartContainerSprite.Draw(spriteBatch, new Vector2(PosX, PosY));
        }

        public void Update()
        {
            BoundingBox = new Rectangle(PosX, PosY, width * 3, height * 3);
            heartContainerSprite.Update();
        }
        public int GetItem()
        {
            return p;
        }
        public static void changeState()
        {
            //do nothing
        }

        public void ChangeSprite(ISprite sprite)
        {
            //do nothing
        }
        public void NextItem(Game1 myGame)
        {


           // myGame.item = new Key();
        }

        public void PreItem(Game1 myGame)
        {

            //myGame.item = new Heart();
        }
    }
}
