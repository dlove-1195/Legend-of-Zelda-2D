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
        private int p = 2;
        public IitemState state;
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


        public int getItem()
        {
            return p;
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
                //state.ChangeToExplode();
                state = new BombAppearExplodeState(this);
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

        public void changeState(IitemState state)
        {
            this.state = state;
        }

        public void changeSprite(ISprite sprite)
        {
            this.bombSprite = sprite;
        }
    }
}
