using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Compass:Iitem
    {
        private int p = 8;
        //Sprite class parameter
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private int sourceLocX = 82;
        private int sourceLocY = 42;
        private int width = 11;
        private int height = 12;

        //Sprite Object
        public ISprite compassSprite;

        //initial position on the ground
        public int posX = 120;
        public int posY = 400;

        public Compass()
        { 
            compassSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

        }


        public void Draw(SpriteBatch spriteBatch)
        {
            compassSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            compassSprite.Update();
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


            myGame.item = new Fairy();
        }

        public void preItem(Game1 myGame)
        {

            myGame.item = new Clock();
        }
    }
}
