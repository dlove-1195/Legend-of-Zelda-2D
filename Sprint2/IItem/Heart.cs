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
        public IStaticitemstate state;
        public ISprite heartSprite;
        //initial position in the center
        public int posX =120;
        public int posY =400;
        
        public Heart()
        {
            state = new HeartAppearState(this);
           
        }
       
        public void Draw(SpriteBatch spriteBatch)
        {
            heartSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            heartSprite.Update();
        }
        public void preItem(Game1 myGame)
        {
           
            myGame.item = new Clock();
            
        }
        public void nextItem(Game1 myGame)
        {
            
            myGame.item = new BlueDiamond();
            
        }
    }
}
