using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{ 
  public class Link : Iplayer 
    {
        public Iplayerstate state;
        public ISprite linkSprite;

        private Vector2 position = new Vector2(200, 200);
        //??? change later
        public static int posY = 200;
        public static int posX = 200;
        public static int currentFrame;
        

         

          public Link()
        {
            
            state = new LinkStandLeftNonAttackNonDamageState(this);
        }
        public void ChangeToRight()
        {
            state.ChangeToRight();
        }
        public void ChangeToLeft()
        {
            state.ChangeToLeft();
        }
        public void ChangeToUp()
        {
            state.ChangeToUp();
        }
        public void ChangeToDown()
        {
            state.ChangeToDown();
        }
        

        public void ChangeToStand()
        {
            state.ChangeToStand();
        }
        public void ChangeToWalk()
        {
            state.ChangeToWalk();
        }

        public void Update()
        {
            linkSprite.Update();
           
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            linkSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public Vector2 GetPosition()
        {
            return position;
        }

        public void SetPosition(int posX, int posY)
        {
            position.X = posX;
            position.Y = posY;
        }



    }
}

