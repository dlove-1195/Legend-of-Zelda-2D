using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlueDiamond : Iitem
    {
        public int count { get; set; } = 0;
        public int totalCount { get; set; } = 100;
        public bool appear { get; set; } = false;
        private int p = 6;
        //Sprite class parameter
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private int sourceLocX = 204;
        private int sourceLocY = 120;
        private int width = 8;
        private int height = 16;

        public Rectangle boundingBox { get; set; }

        //Sprite Object
        private ISprite blueDiamondSprite;

        //initial position on the ground
        public int posX { get; set; }
        public int posY { get; set; }


        public BlueDiamond(Vector2 vector)
        {
            posX = (int)vector.X;
            posY = (int)vector.Y;
            blueDiamondSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

        }
        public int getItem()
        {
            return p;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            blueDiamondSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
            blueDiamondSprite.Update();
        }

        public void nextItem(Game1 myGame)
        {


          //  myGame.item = new Clock();


        }

        public void preItem(Game1 myGame)
        {

           // myGame.item = new TriforcePiece();
        }

        public static void changeState()
        {
            //do nothing
        }

        public void changeSprite(ISprite sprite)
        {
            //do nothing
        }


    }
}
