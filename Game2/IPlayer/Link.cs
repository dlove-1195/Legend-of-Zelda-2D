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
        public Iitem bomb;
        public Iitem sword;

        //add
        public Iitem bow;
        public Iitem arrow;
        public Iitem boomerang;
        public Iitem bluecandle;
        //end

        public int x =0;

        private Vector2 position = new Vector2(200, 200);
        //??? change later
        public static int posY = 200;
        public static int posX = 200;
        public static Boolean ifDamage = false;
        public int timer = 0;
        
          public Link()
        {
            
            state = new LinkStandRightNonAttackNonDamageState(this);
            
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
      

        public void GetDamaged()
        {
            state.GetDamaged();
        }
        public void Attack()
        {
            state.Attack();
        }

        /*        public void LinkWithBomb()
                {

                    state.LinkWithBomb();

                }

                public void LinkWithSword()
                {
                    state.LinkWithSword();
                }*/

            //add
        public void LinkWithItemLeftState(Iitem item) {
            state.LinkWithItemLeft(item);
        }
        public void LinkWithItemRightState(Iitem item) {
            state.LinkWithItemRight(item);
        }
        public void LinkWithItemUpState(Iitem item) {
            state.LinkWithItemUp(item);
        }
        public void LinkWithItemDownState(Iitem item) {
            state.LinkWithItemDown(item);
        }
            //end

        public void Update()
        {
            linkSprite.Update();
            if (bomb != null)
            {
                bomb.Update();
            }
            if (sword != null)
            {
                sword.Update();
            }
            //new add
            if ( bow!= null)
            {
                bow.Update();
                
            }
            if (bluecandle!= null)
            {
                bluecandle.Update();
            }
            if (arrow != null)
            {
                arrow.Update();
            }
            if (boomerang != null)
            {
                boomerang.Update();
            }
            //end
            if (ifDamage)
            {
                timer++;
                if(timer == 100)
                {
                    ifDamage = false;
                }
            }
            else
            {
                timer = 0;
            }
           
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            linkSprite.Draw(spriteBatch, new Vector2(posX, posY));
            if (bomb != null)
            {
                bomb.Draw(spriteBatch);
            }
            if (sword != null)
            {
                sword.Draw(spriteBatch);
            }
            if (bow != null)
            {
                bow.Draw(spriteBatch);
            }
            if (bluecandle != null)
            {
                bluecandle.Draw(spriteBatch);
            }
            if (boomerang != null)
            {
                boomerang.Draw(spriteBatch);
            }
            if (arrow != null)
            {
                arrow.Draw(spriteBatch);
            }
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
        public void ChangeX(int i)
        {
            x = i;
        }

        public int GetDirection()
        {

            return x;
        }
    }
}

