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
        private int p = 11;
        //Sprite class parameter
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private int sourceLocX = 241;
        private int sourceLocY = 41;
        private int width = 13;
        private int height = 13;

        //Sprite Object
        public ISprite heartContainerSprite;

        //initial position on the ground
        public int posX = 120;
        public int posY = 400;

        public HeartContainer()
        {
            heartContainerSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

        }


        public void Draw(SpriteBatch spriteBatch)
        {
            heartContainerSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            heartContainerSprite.Update();
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


            myGame.item = new Key();
        }

        public void preItem(Game1 myGame)
        {

            myGame.item = new Heart();
        }
    }
}
