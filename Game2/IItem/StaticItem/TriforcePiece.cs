using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class TriforcePiece : Iitem
    {
        private int p = 14;
        //Sprite class parameter
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private int sourceLocX = 343;
        private int sourceLocY = 123;
        private int width = 10;
        private int height = 10;
        public Rectangle boundingBox { get; set; }
        //Sprite Object
        public ISprite triforcePieceSprite;

        //initial position on the ground
        public int posX;
        public int posY ;

        public TriforcePiece(Vector2 vector)
        {
            posX = (int)vector.X;
            posY = (int)vector.Y;
            triforcePieceSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

        }


        public void Draw(SpriteBatch spriteBatch)
        {
            triforcePieceSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
            triforcePieceSprite.Update();
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
        public void nextItem(Game1 myGame)
        {


            myGame.item = new BlueDiamond();
        }

        public void preItem(Game1 myGame)
        {

            myGame.item = new Map();
        }
    }
}
