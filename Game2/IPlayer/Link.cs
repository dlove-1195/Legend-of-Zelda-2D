using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{ 
  public class Link : IPlayer 
    {
        public IPlayerstate state;
        public ISprite linkSprite;
     
        public List<IItem> items = new List<IItem>();

        private int direction ;
         
        /* public int positionX { get; set; } = 200 ;
         public int positionY { get; set; } = 200;  better choice
          can be used in sprite class, change later -------- */
        public static int posY ;
        public static int posX ;
        public static Boolean ifDamage = false;
      
        public static int damageTimer = 0; 
       
        //----for detection class --- start
        private int linkWidth = 14 ;
        private int linkHeight = 14;
        
        public Rectangle boundingBox { get; set; }
        public Rectangle simpleAttackBox { get; set; }
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
            simpleAttackBox = new Rectangle(0, 0, 0, 0);


        }
        public void ChangeToLeft()
        {
            state.ChangeToLeft();
            simpleAttackBox = new Rectangle(0, 0, 0, 0);

        }
        public void ChangeToUp()
        {
            state.ChangeToUp();
            simpleAttackBox = new Rectangle(0, 0, 0, 0);

        }
        public void ChangeToDown()
        {
            state.ChangeToDown();
            simpleAttackBox = new Rectangle(0, 0, 0, 0);

        }
        

        public void ChangeToStand()
        {
            state.ChangeToStand();
            
        }
        public void ChangeToWalk()
        {
            state.ChangeToWalk();
            simpleAttackBox = new Rectangle(0, 0, 0, 0);

        }
      

        public void GetDamaged()
        {
            state.GetDamaged();
            simpleAttackBox = new Rectangle(0, 0, 0, 0);


        }
        public void Attack()
        {
            state.Attack();
       
        }
        public void Win()
        {
            state.Win();
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
            foreach (IItem item in items)
            {
                item.Update();
            }
            if (ifDamage)
            {
                damageTimer++;
                if(damageTimer >= 100)
                {
                    ifDamage = false;
                }
            }
            else
            {
                damageTimer = 0;
            }

            manageLinkItem();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
             
            linkSprite.Draw(spriteBatch, new Vector2(posX, posY));
            foreach (IItem item in items)
            {
                item.Draw(spriteBatch);
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

            foreach (IItem item in items)
            {
                weaponRec.Add(item.BoundingBox);
            }
           
            return weaponRec;
        }

        public void manageLinkItem()
        {
            foreach (IItem item in items)
            {
                item.Count++;
                if(item.Count >= item.TotalCount)
                {
                    item.Appear = false;
                    item.Count = 0;
                    
                }
            }
            for(int i=0; i<items.Count; i++)
            {
                if (!items[i].Appear)
                {
                    items.RemoveAt(i);
                }
            }
            

        }
    }
}

