using Microsoft.Xna.Framework;
using System;
 

namespace Sprint2
{
    class LinkCollisionHandler 
    {

        Iplayer link;
        IRoom room;
        ILevel level;
        
        public LinkCollisionHandler(Iplayer link, ILevel level)
        {
            this.link = link;
            this.room = level.room;
            this.level = level;
            
        }

        
        public void HandleLinkBlockCollsion(string direction)
        {
            
            switch (direction)
            {
                case "Left":
                    Link.posX -=2;
                    break;
                case "Right":
                    Link.posX +=2;
                    break;
                case "Up":
                    Link.posY +=2;

                    break;
                case "Down":
                    Link.posY -=2;
                    break;

                default:
                    Console.WriteLine("error: no such situation");
                    break;
            }
        }

        public void HandleLinkStairCollsion(Vector2 destRoomPos, String direction)
        {
            //switch room to destRoomPos
            
            switch (direction)
            {
                case "Left":
                    direction = "Right";
                    break;
                case "Right":
                    direction = "Left";
                    break;
                
            }
            level.switchUnderground(destRoomPos, direction);

        }

        public void HandleLinkDoorCollsion(string direction)
        {

            level.switchRoom(direction);
                 
            
        }
            public void HandleLinkEnemyCollsion(string direction)
        {
            //link get damaged and being pushed to opposite direction
            link.GetDamaged();
            switch (direction)
            {
                case "Left":
                    Link.posX = Link.posX -3;
                    break;
                case "Right":
                    Link.posX= Link.posX + 3;
                    break;
                case "Up":
                    Link.posY =Link.posY+3;

                    break;
                case "Down":
                    Link.posY = Link.posY - 3;
                    break;

                default:
                    Console.WriteLine("error: no such situation");
                    break;
            }

        }

        public void HandleLinkProjectileCollsion()
        {
            //link just damage
            link.GetDamaged();
        }

        public void HandleLinkWeaponEnemyCollsion(  int enemyNum)
        {
            //enemy damage, disappear directly 
             room.setEnemyToNull(enemyNum);
            //-----FIXME-----------
             //enemy damage, drop blood or disappear 
             //maybe need add a field in enemy class to record the live of the enemy 
        }
        public void HandleLinkNpcCollsion(String direction)
        {
            switch (direction)
            {
                case "Left":
                    Link.posX-=2; 
                    break;
                case "Right":
                    Link.posX +=2 ;
                    break;
                case "Up":
                    Link.posY +=2;

                    break;
                case "Down":
                    Link.posY -=2;
                    break;

                default:
                    Console.WriteLine("error: no such situation");
                    break;
            }
            
            
            //----FIXME---------
            //may need to draw something on the screen
            //to show the communication with npc
        }

        public void HandleLinkItemCollsion(int itemNum)
        {
            //item disappear 
            room.setItemToNull(itemNum);

            //FIXME
            //later add field to show how many items link have 
        }

        public void remainPosition(string direction)
        {
            
            switch(direction)
              
            {
                case "Left":
                    Link.posX+=2;
                    break;
                case "Right":
                    Link.posX-=2;
                    break;
                case "Up":
                    Link.posY+=2;
                  
                    break;
                case "Down":
                    Link.posY-=2;
                    break;
                
                default:
                    Console.WriteLine("error: no such situation");
                    break;
            }
        }




    }
}
