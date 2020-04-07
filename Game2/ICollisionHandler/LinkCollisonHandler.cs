using Microsoft.Xna.Framework;
using System;
 

namespace Sprint2
{
    class LinkCollisionHandler 
    {

        IPlayer link;
        IRoom room;
        ILevel level;
        
        public LinkCollisionHandler(IPlayer link, ILevel level)
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
            Sound.PlayLinkDemage();
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
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                    Console.WriteLine("error: no such situation");
#pragma warning restore CA1303 // Do not pass literals as localized parameters
                    break;
            }

        }

        public void HandleLinkProjectileCollsion()
        {
            //link just damage
            Sound.PlayLinkDemage();
            link.GetDamaged();
        }

        public void HandleLinkWeaponEnemyCollsion(  int enemyNum )
        {
            //enemy damage 
            Sound.PlayLinkDemage();
            room.enemies[enemyNum].blood--; ;
             
            if (room.enemies[enemyNum]!=null &&room.enemies[enemyNum].blood <= 0 )
            {
                room.setEnemyToNull(enemyNum);
            }
            //-----FIXME-----------
             //enemy damage, drop blood or disappear 
             //maybe need add a field in enemy class to record the live of the enemy 
        }
        public void HandleLinkNpcCollsion(String direction)
        {
            Sound.PlayItemCollision();
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
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                    Console.WriteLine("error: no such situation");
#pragma warning restore CA1303 // Do not pass literals as localized parameters
                    break;
            }
            
            
            //----FIXME---------
            //may need to draw something on the screen
            //to show the communication with npc
        }

        public void HandleLinkItemCollsion(int itemNum)
        {
            //item disappear 
            Sound.PlayItemCollision();
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
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                    Console.WriteLine("error: no such situation");
#pragma warning restore CA1303 // Do not pass literals as localized parameters
                    break;
            }
        }




    }
}
