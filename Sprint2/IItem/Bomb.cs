using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace Sprint2
{
    class Bomb : Iitem
    {
        public Iitemstate state;
        public ISprite bombSprite;
        //initial position closed to link
        public int posX;
        public int posY;

        public void explore()
        {
            //special method for class Bomb
        }
        public void Appear()
        {
            
        }

        public void Disappear()
        {
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            bombSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void goDown()
        {
            
        }

        public void goLeft()
        {
            
        }

        public void goRight()
        {
            
        }

        public void goUp()
        {
            
        }

        public void Update()
        {
            bombSprite.Update();
        }
    }
}
