using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sprint2 {

    public class LinkCollisionDetection : ICollisionDetection
    {
        //string to determine collision type : up,down,left, right 
        private LinkCollisionHandler linkHandler;
        private List<IEnemy> enemy;
        private List<Iitem> item;
        private List<Inpc> npc;
        private List<KeyValuePair<int, int>> blockLocation;
        private List<KeyValuePair<int, int>> doorLocation;
      
        private Iplayer player ;
        private int roomWidth;
        private int roomHeight;
        

        public  LinkCollisionDetection (ILevel level, Iplayer link)
        {
            
            IRoom room = level.room;
            roomWidth =(int)  room.roomPos.X;
            roomHeight =(int) room.roomPos.Y;
            enemy = room.enemies;
            item =  room.pickUpItems;
            npc =  room.npcs;
            blockLocation =  room.blockLocation;
            doorLocation = room.doorLocation;

            player = link;
            linkHandler =new LinkCollisionHandler(player, level) ;
    }

        public void Update()
        {


            Rectangle overlapRec;
       
            Rectangle linkRectangle = player.boundingBox;
            //loop for link/enemy collision 
            int listLength = enemy.Count();
            for(int i = 0;i< listLength; i++)
            {
                Rectangle singleEnemyRec = enemy[i].boundingBox;
                //detect link body collision with enemy body 
                 overlapRec = Rectangle.Intersect(linkRectangle, singleEnemyRec);
                if (!overlapRec.IsEmpty)
                {
                    //link damage and being pushed in opposite direction
                   String direction= detectCollisionDirection(overlapRec, linkRectangle, singleEnemyRec);
                    linkHandler.HandleLinkEnemyCollsion(direction);
                }
                 


                //detect link collision with enemy projectile 
                List<Rectangle> EnemyProjectileRec = enemy[i].getProjectileRec();
                for (int j = 0; j < EnemyProjectileRec.Count(); j++)
                {
                     overlapRec = Rectangle.Intersect(linkRectangle, EnemyProjectileRec[j]);
                    if (!overlapRec.IsEmpty)
                    {
                        //link damage by projectile, will not be pushed
                         
                        linkHandler.HandleLinkProjectileCollsion();
                        
                    }
                     
                }
 
                // detect link weapon collison with enemy 
                List<Rectangle> linkWeaponRec =player.getUsingItemRec();
                for(int j= 0; j<linkWeaponRec.Count(); j++)
                {
                      overlapRec = Rectangle.Intersect(linkRectangle, linkWeaponRec[j]);
                    if (!overlapRec.IsEmpty)
                    {
                        //enemy damage 
                        linkHandler.HandleLinkWeaponEnemyCollsion( i);
                    }
                     
                     
                }
  
            }

            //loop for link/item collsion 

            listLength = item.Count();
            for (int i = 0; i < listLength; i++)
            {
                Rectangle singleItemRec = item[i].boundingBox;
                
                overlapRec = Rectangle.Intersect(linkRectangle, singleItemRec);
                if (!overlapRec.IsEmpty)
                {

                    linkHandler.HandleLinkItemCollsion(i);
                }
 
            }


            //loop for link/NPC collsion 

            listLength = npc.Count();
            for (int i = 0; i < listLength; i++)
            {
                Rectangle singleNpcRec = npc[i].boundingBox;
                overlapRec = Rectangle.Intersect(linkRectangle, singleNpcRec);
                if (!overlapRec.IsEmpty)
                {
                    linkHandler.HandleLinkNpcCollsion();
                }
                
 

            }

            //loop for link/Block collsion 

            listLength = blockLocation.Count();
            for (int i = 0; i < listLength; i++)
            {
                KeyValuePair<int, int> singleBlockLocation = blockLocation[i];
                //for now, assume block width and height are 100, will change later based on the doungeon spritesheet we found 
                Rectangle singleBlockRec = new Rectangle(singleBlockLocation.Key, singleBlockLocation.Value,
                    100, 100);

                overlapRec = Rectangle.Intersect(linkRectangle,  singleBlockRec);
                if (!overlapRec.IsEmpty)
                {
                    String direction = detectCollisionDirection(overlapRec, linkRectangle, singleBlockRec);
                    linkHandler.HandleLinkBlockCollsion(direction);
                   
                }
                


            }


            //loop for door collision 
            listLength = doorLocation.Count();
            for (int i = 0; i < listLength; i++)
            {
                KeyValuePair<int, int> singleDoorLocation = doorLocation[i];
                //for now, assume block width is 100 and height is 20, will change later based on the doungeon spritesheet we found 
                Rectangle singleDoorRec = new Rectangle(singleDoorLocation.Key, singleDoorLocation.Value,
                    100, 20);

                overlapRec = Rectangle.Intersect(linkRectangle, singleDoorRec);
                if (!overlapRec.IsEmpty)
                {
                    String direction = detectCollisionDirection(overlapRec, linkRectangle, singleDoorRec);
                    linkHandler.HandleLinkDoorCollsion(direction);

                }



            }














            //link edge collison 
            if (Link.posX > roomWidth)
            {
                linkHandler.remainPosition(  "right");
            }else if (Link.posX < 0)
            {
                linkHandler.remainPosition(  "left");
            }else if (Link.posY > roomHeight)
            {
                linkHandler.remainPosition( "down");
            }else if(Link.posY < 0)
            {
                linkHandler.remainPosition(  "up");
            }
                 
          
        }
        
 
         
        public string detectCollisionDirection(Rectangle overlapRec, Rectangle linkRec, Rectangle objectRec)
        {
 
            string direction;
            if (overlapRec.Width >= overlapRec.Height) //top/buttom collison
            {
                if (linkRec.Y >= objectRec.Y)
                {
                    direction = "top";
                }
                else
                {
                    direction = "bottom";
                }
            }
            else //left/right collison
            {
                if (linkRec.X >= objectRec.X)
                {
                    direction = "right";
                }
                else
                {
                    direction = "left";
                }

            }
                  
                return direction;
        }
 
    }
}

    
 
    
 
