using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    class Sword:Iitem
    {
        public Iitemstate state;
        public ISprite swordSprite;
        //initial position which closed to Link
        public int posX;
        public int posY;
        

        public Sword()
        {
            //constructor, initialize state
        }
        public void Appear()
        {

        }
        public void Disappear()
        {

        }
       public void Update() {
            swordSprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            swordSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void goUp()
        {
            
        }

        public void goDown()
        {
            
        }

        public void goRight()
        {
            
        }

        public void goLeft()
        {
            
        }
    }
}
