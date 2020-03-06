using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 {

    public class LinkCollisionDetection : ICollisionDetection
    {
        //string to determine collision type : up,down,left, right 
        private LinkCollisionHandler linkHandler;
        private List<IEnemy> enemy;
        private List<Iitem> item;
        private List<Inpc> npc;
        private List<KeyValuePair<int, int>> blockLocation;
        //private List<Iitem> projectile; 
        private Iplayer player ;
        private int roomWidth;
        private int roomHeight;

        public  LinkCollisionDetection (IRoom room, Iplayer link)
        {
            roomWidth = room.vector.x;
            roomHeight = room.vector.y;
            enemy = room.enemy;
            item = room.item;
            npc = room.npc;
            blockLocation = room.blockLocation;
            player = link;
            linkHandler =new LinkCollisionHandler(player) ;
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
                    //link damage
                    linkHandler.HandleLinkEnemyCollsion();
                }

                 
                    
                    
               
                //detect link collision with enemy projectile 
                List<Rectangle> EnemyProjectileRec = enemy[i].getProjectileRec();
                for (int j = 0; j < EnemyProjectileRec.Count(); j++)
                {
                     overlapRec = Rectangle.Intersect(linkRectangle, EnemyProjectileRec[j]);
                    if (!overlapRec.IsEmpty)
                    {
                        //link damage
                        linkHandler.HandleLinkEnemyCollsion();
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
                        linkHandler.HandleLinkWeaponEnemyCollsion(enemy[i]);
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
                    linkHandler.HandleLinkItemCollsion();
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
                    linkHandler.HandleLinkBlockCollsion();
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
        
 
        //maybe need to add a another helping method to detect direction, return a string
        //call this method inside the update before handleCollison method
        //use Rectangle.Intersect(recA, recB) 
        //return a new rec that is the overlap area, otherwise an empty rec

        public string detectCollisionDirection(Rectangle overlapRec, Rectangle objectRec)
        {
 
            string direction; 
                  
                return "";
        }
 
    }
}

    
 