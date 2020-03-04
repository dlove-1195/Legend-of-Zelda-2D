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
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private int sourceLocX = 241;
        private int sourceLocY = 41;
        private int width = 13;
        private int height = 13;

        //Sprite Object
        public ISprite heartSprite;

        //initial position in the center
        public int posX =120;
        public int posY =400;
        
        public Heart()
        {
            heartSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

        }
       
        public void Draw(SpriteBatch spriteBatch)
        {
            heartSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
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
           
            myGame.item = new Fairy();
            
        }
        public void nextItem(Game1 myGame)
        {
            
            myGame.item = new HeartContainer();
            
        }
    }
}
