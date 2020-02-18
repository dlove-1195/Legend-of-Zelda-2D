using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace Sprint2
{
    public class Bomb : Iitem
    {
        public IBombitemstate state;
        public ISprite bombSprite;
        private int delay = 0;
        //initial position closed to link
        public   int posX;
        public   int posY;
        
        public Bomb(int posX, int posY)
        {
             
            state = new BombAppearUnExplodeState(this);
            this.posX = posX;
            this.posY = posY; 
        }

        
         

        public void Draw(SpriteBatch spriteBatch)
        {
            bombSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }
       

        public void Update()
        {
            bombSprite.Update();

            int totalDelay = 100;
            delay++;
            if(delay > 80 && delay<totalDelay)
            {
                state.ChangeToExplode();

            }
            else if(delay>=totalDelay)
            {
                state.ChangeToDisappear();
            }
            
         
        }

        public void nextItem(Game1 myGame)
        {
            
        }

        public void preItem(Game1 myGame)
        {
             
        }
    }
}
