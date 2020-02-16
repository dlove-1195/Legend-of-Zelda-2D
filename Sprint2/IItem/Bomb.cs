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
        public IBombitemstate state;
        public ISprite bombSprite;
        //initial position closed to link
        public int posX;
        public int posY;

        public Bomb()
        {
            state = new BombAppearUnExplodeState(this);
        }

        public void explode()
        {
            state.ChangeToExplode();
        }
        public void Appear()
        {
            state.ChangeToAppear();
        }

        public void Disappear()
        {
            state.ChangeToDisappear();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            bombSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }
       

        public void Update()
        {
            bombSprite.Update();
        }

        public void nextItem()
        {
            throw new NotImplementedException();
        }

        public void preItem()
        {
            throw new NotImplementedException();
        }
    }
}
