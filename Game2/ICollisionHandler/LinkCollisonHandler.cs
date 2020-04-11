using Microsoft.Xna.Framework;
using System;
 

namespace Sprint2
{
    class LinkCollisionHandler 
    {

        private IPlayer link;
        private IRoom room;
        private ILevel level;
        private IInventory inventory;
      public LinkCollisionHandler(IPlayer link, ILevel level, IInventory inventory)
        {
            this.link = link;
            this.room = level.room;
            this.level = level;
            this.inventory = inventory;
            
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
            Link.damageTimer = 0;
            //link get damaged and being pushed to opposite direction
            if (!Link.ifDamage)
            {
                inventory.heartNum--;
            }
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
            Link.damageTimer = 0;
            Sound.PlayLinkDemage();
            if (!Link.ifDamage)
            {
                inventory.heartNum--;
            }
            link.GetDamaged();
           
        }

       public void HandleLinkWeaponEnemyCollsion(int enemyNum)
        {
            if (room.enemies[enemyNum] != null) { 
                //enemy damage 
                Sound.PlayLinkDemage();
                //FIXME LATER
                //there is a bug here, continue attack and get null exception
                
                
                if (room.enemies[enemyNum] is GreenDragon || room.enemies[enemyNum] is Dragon)
                {
                    room.enemies[enemyNum].GetDamage();

                }
                else
                {
                    room.enemies[enemyNum].blood--;
                }

            

            }
      
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
            itemManager(itemNum);
            room.setItemToNull(itemNum);
            
            
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

        public void itemManager(int itemNum)
        {
            if (room.pickUpItems[itemNum] is YellowDiamond)
            {
                inventory.diamondNum++;
                //max life 12
            }else if(room.pickUpItems[itemNum] is Heart && inventory.heartNum<=11)
            {
                inventory.heartNum++;
            }
            else if (room.pickUpItems[itemNum] is staticBomb)
            {
                if (!inventory.itemList.Contains("bomb"))
                {
                    inventory.itemList.Add("bomb");
                }
                inventory.bombNum++;
            }
            else if (room.pickUpItems[itemNum] is Key)
            {
                inventory.keyNum++;
            }
            else if (room.pickUpItems[itemNum] is TriforcePiece)
            {
                inventory.triPieceNum++;
            }else if(room.pickUpItems[itemNum] is staticBow)
            {
                if (!inventory.itemList.Contains("bow"))
                {
                    inventory.itemList.Add("bow");
                }
            }else if(room.pickUpItems[itemNum] is staticCandle)
            {
                if (!inventory.itemList.Contains("candle"))
                {
                    inventory.itemList.Add("candle");
                }
            }else if (room.pickUpItems[itemNum] is staticWoodenBoomerang)
            {
                if (!inventory.itemList.Contains("boomerang"))
                {
                    inventory.itemList.Add("boomerang");
                }
            }else if(room.pickUpItems[itemNum] is Map)
            {
                inventory.showMap = true;
            }else if(room.pickUpItems[itemNum] is Compass)
            {
                inventory.showCompass = true;
            }else if(room.pickUpItems[itemNum] is Clock)
            {
                //room need to stop update
                level.roomUpdate = false;
            }

            //if items  fairy? /heartContainer?
            //later

        }




    }
}
