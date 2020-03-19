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
      
        private int damageTimer = 0; 
       
        //----for detection class --- start
        private int linkWidth = 15 ;
        private int linkHeight = 16;
        
        public Rectangle boundingBox { get; set; }
        // ---  end ---

        // handle link's items 
        // sequence: bomb, sword, arrow(bow), boomerang, candle

        private List< int> itemTimer = new List<int>() { 0,0,0,0,0};
        private List<int> totalItemDelay = new List<int>() { 100,100, 100, 48, 100};
        public static List<Boolean> linkWithItem = new List<Boolean> { false, false, false, false, false };
         
        public Link(Vector2 position)
        {
            posX = (int)position.X;
            posY = (int)position.Y;
         
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
            //link's bounding box should be larger when attack
            switch (direction)
            {
                case 1:
                    linkWidth = 15;
                    linkHeight = 21;
                    boundingBox = new Rectangle(posX, posY-5, linkWidth * 3, linkHeight * 3);
                    break;
                case 2:
                    linkWidth = 20;
                    linkHeight = 16;
                    boundingBox = new Rectangle(posX, posY+5, linkWidth * 3, linkHeight * 3);

                    break;
                case 3:
                    linkWidth = 20;
                    linkHeight = 16;
                    boundingBox = new Rectangle(posX-5, posY, linkWidth * 3, linkHeight * 3);
                    break;
                case 0:
                    linkWidth = 15;
                    linkHeight = 21;
                    boundingBox = new Rectangle(posX+5, posY, linkWidth * 3, linkHeight * 3);
                    break;
                default:
                    Console.WriteLine("should not happen ");
                    break;


            }
            
             


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
            if (bomb != null)
            {
                bomb.Draw(spriteBatch);
            }
            if (sword != null)
            {
                sword.Draw(spriteBatch);
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

            
            if (arrow != null)
            {
                weaponRec.Add(arrow.boundingBox);
            }
            if (boomerang != null)
            {
                weaponRec.Add(boomerang.boundingBox);
            }

            return weaponRec;
        }

        public void manageLinkItem()
        {
            for (int i = 0; i<linkWithItem.Count;i++)
            {
                if (linkWithItem[i])
                {
                    itemTimer[i]++;
                    if (itemTimer[i] == totalItemDelay[i])
                    {
                        linkWithItem[i] = false;
                    }
                }
                else
                {
                    itemTimer[i] = 0;
                    switch (i)
                    {
                        case 0:
                            bomb = null;
                            break;
                        case  1:
                            sword = null;
                            break;
                        case 2:
                            arrow = null;
                            break;
                        case 3:
                            boomerang = null;
                            break;
                        case 4:
                            bluecandle = null;
                            break;
                       
                        default:
                            Console.WriteLine("error:link doesn't use the item");
                            break;
                    }


                }
            }
        }
    }
}

