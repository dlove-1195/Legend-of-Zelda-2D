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
        public IitemState state;
        public ISprite blueDiamondSprite;
        //initial position on the ground
        public int posX = 120;
        public int posY =400;
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        public BlueDiamond()
        {
            blueDiamondSprite = new ItemBlueDiamondSprite(texture);

        }
         

        public void Draw(SpriteBatch spriteBatch)
        {
            blueDiamondSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Update()
        {
            blueDiamondSprite.Update();
        }

        public void nextItem(Game1 myGame)
        {
            
           
             myGame.item = new Clock();
        }

        public void preItem(Game1 myGame)
        {
           
            myGame.item = new Heart();
        }
    }
}
