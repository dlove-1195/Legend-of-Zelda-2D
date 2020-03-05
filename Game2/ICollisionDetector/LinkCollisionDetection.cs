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
        private ICollisionHandler linkHandler;
        private List<IEnemy> enemy;
        private List<Iitem> item;
        private List<Inpc> npc;
        private List<KeyValuePair<int, int>> blockLocation;
        //private List<Iitem> projectile; 
        private Iplayer player ;
      
       public  LinkCollisionDetection (IRoom room, Iplayer link)
        {

            enemy = room.enemy;
            item = room.item;
            npc = room.npc;
            blockLocation = room.blockLocation;
            player = link;
            linkHandler =new LinkCollisionHandler(player) ;
    }

        public void Update()
        {

            

            Rectangle linkRectangle = player.boundingBox;
            //loop for link/enemy collision 
            int listLength = enemy.Count();
            for(int i = 0;i< listLength; i++)
            {
                Rectangle singleEnemyRec = enemy[i].boundingBox;
                if (linkRectangle.Intersects(singleEnemyRec))
                {

                    linkHandler.HandleLinkEnemyCollsion();
                }

               

                if(enemy[i].Equals(new Dragon()))
                {   

                }


                // link weapon collison with enemy 

                
                
            }

            //loop for link/item collsion 

            listLength = item.Count();
            for (int i = 0; i < listLength; i++)
            {
                Rectangle singleItemRec = item[i].boundingBox;
                if (linkRectangle.Intersects(singleItemRec))
                {

                    linkHandler.HandleLinkItemCollsion();
                }


            }


            //loop for link/NPC collsion 

            listLength = npc.Count();
            for (int i = 0; i < listLength; i++)
            {
                Rectangle singleNpcRec = npc[i].boundingBox;
                if (linkRectangle.Intersects(singleNpcRec))
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

                if (linkRectangle.Intersects(singleBlockRec))
                {

                    linkHandler.HandleLinkBlockCollsion();
                }


            }

        }



        //maybe need to add a another helping method to detect direction, return a string
        //call this method inside the update before handleCollison method
        //use Rectangle.Intersect(recA, recB) 
        //return a new rec that is the overlap area, otherwise an empty rec







    }
}

    
 