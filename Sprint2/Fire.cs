using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class Fire
    {
        public IItemState state;
        public ISprite fireSprite;
        
        public Fire()
        {

            state = new FireDisappearState(this);
        }
        
        public void ChangeToDisappear()
        {
            state.ChangeToDisappear();

        }

        public void ChangeToAppear()
        {
            state.ChangeToAppear();
        }


        public void Update()
        {
            fireSprite.Update();
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            fireSprite.Draw(spriteBatch, new Vector2((Dragon.posX-30), Dragon.posY));
        }


    }
}
