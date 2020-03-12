using System;
using System.Collections.Generic;
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


       
        public Iitem bow;
        public Iitem arrow;
        public Iitem boomerang;
        public Iitem bluecandle;
        

        private int direction ;

         
       
        /* public int positionX { get; set; } = 200 ;
         public int positionY { get; set; } = 200;  better choice
          can be used in sprite class, change later -------- */
        public static int posY ;
        public static int posX ;
        public static Boolean ifDamage = false;
        public static Boolean ifAttack = false;
        private int damageTimer = 0;
        private int attackTimer = 0;
        
       
        //----for detection class --- start
        private int linkWidth = 15 ;
        private int linkHeight = 16;
       

        public Rectangle boundingBox { get; set; } 
        // ---  end ---
        public Link(Vector2 position)
        {
            posX = (int)position.X;
            posY = (int)position.Y;

            state = new LinkStandRightNonAttackNonDamageState(this);
            

            
        }
        public void ChangeToRight()
        {
            state.ChangeToRight();
            linkWidth = 20;
            linkHeight = 16;

        }
        public void ChangeToLeft()
        {
            state.ChangeToLeft();
            linkWidth = 20;
            linkHeight = 16;

        }
        public void ChangeToUp()
        {
            state.ChangeToUp();
            linkWidth = 20;
            linkHeight = 16;

        }
        public void ChangeToDown()
        {
            state.ChangeToDown();
            linkWidth = 20;
            linkHeight = 16;

        }
        

        public void ChangeToStand()
        {
            state.ChangeToStand();
            linkWidth = 20;
            linkHeight = 16;
        }
        public void ChangeToWalk()
        {
            state.ChangeToWalk();
            linkWidth = 20;
            linkHeight = 16;
        }
      

        public void GetDamaged()
        {
            state.GetDamaged();
            linkWidth = 20;
            linkHeight = 16;
        }
        public void Attack()
        {
            state.Attack();
            switch (direction)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 0: 
                    break;
                default:
                    Console.WriteLine("should not happen ");
                    break;


            }
            linkWidth = 20;
            linkHeight = 16;
             


        }

        
            //add
        public void SetLinkWithItemLeftState(int itemNum) {
            state.LinkWithItemLeft(itemNum);
        }
        public void SetLinkWithItemRightState(int itemNum) {
            state.LinkWithItemRight(itemNum);
        }
        public void SetLinkWithItemUpState(int itemNum) {
            state.LinkWithItemUp(itemNum);
        }
        public void SetLinkWithItemDownState(int itemNum) {
            state.LinkWithItemDown(itemNum);
        }
            //end

        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, linkWidth * 3, linkHeight * 3);
            linkSprite.Update();
            if (bomb != null)
            {
                bomb.Update();
            }
            if (sword != null)
            {
                sword.Update();
            }
            
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
            
            if (ifDamage)
            {
                damageTimer++;
                if(damageTimer == 100)
                {
                    ifDamage = false;
                }
            }
            else
            {
                damageTimer = 0;
            }


            if (ifDamage)
            {
                attackTimer++;
                if (attackTimer == 25)
                {
                    ifAttack = false;
                }
            }
            else
            {
                attackTimer = 0;
                
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

       
       
        
         public void ChangeDirection(int i)
        {
            direction = i;
        }  

        public int GetDirection()
        {

            return direction;
        }

        public List<Rectangle> getUsingItemRec()
        {

            //detect all the items that link is current using 
            //add those items' current rectangle in a list and use in the collision detection class
            List<Rectangle> weaponRec = new List<Rectangle>();
            if (bomb != null)
            {

                weaponRec.Add(bomb.boundingBox);

            }

            if (sword != null)
            {
                weaponRec.Add(sword.boundingBox);
            }

            if (bow != null)
            {
                weaponRec.Add(bow.boundingBox);
            }
            if (arrow != null)
            {
                weaponRec.Add(arrow.boundingBox);
            }
            if (boomerang != null)
            {
                weaponRec.Add(bomb.boundingBox);
            }

            return weaponRec;
        }
    }
}

