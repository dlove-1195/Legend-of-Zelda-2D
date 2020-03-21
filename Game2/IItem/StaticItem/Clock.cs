using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Clock : Iitem
    {
        public int count { get; set; } = 0;
        public int totalCount { get; set; } = 100;
        public bool appear { get; set; } = false;
        private int p = 7;
        //Sprite parameters
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private int sourceLocX = 362;
        private int sourceLocY = 0;
        private int width = 11;
        private int height = 16;

        public Rectangle boundingBox { get; set; }

        //Sprite Object
        public ISprite clockSprite;

        //initial position on the ground
        public int posX { get; set; }
        public int posY { get; set; }

        public Clock(Vector2 vector)
        {
            posX = (int)vector.X;
            posY = (int)vector.Y;
            clockSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);
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

        public void Draw(SpriteBatch spriteBatch)
        {
            clockSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
            clockSprite.Update();
        }


        public void preItem(Game1 myGame)
        {
            //state.ChangeToDisappear();
           // myGame.item = new BlueDiamond();
        }
        public void nextItem(Game1 myGame)
        {
            //state.ChangeToDisappear();
           // myGame.item = new Compass();
        }
    }
}
