using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class LinkCollisionHandler 
    {

        Iplayer link; 
        public LinkCollisionHandler(Iplayer link)
        {
            this.link = link;
        }

        // public void HandleLinkNpcCollsion(String side);
        //may need add side in the future 
        public void HandleLinkBlockCollsion(string direction)
        {
            int originPosX = Link.posX;
            int originPosY = Link.posY;
            switch (direction)
            {
                case "left":
                    Link.posX --;
                    break;
                case "right":
                    Link.posX ++;
                    break;
                case "up":
                    Link.posY --;

                    break;
                case "down":
                    Link.posY  ++;
                    break;

                default:
                    Console.WriteLine("error: no such situation");
                    break;
            }
        }
        public void HandleLinkEnemyCollsion(string direction)
        {
            //link get damaged and being pushed to opposite direction
            link.GetDamaged();
            switch (direction)
            {
                case "left":
                    Link.posX = Link.posX -3;
                    break;
                case "right":
                    Link.posX= Link.posX + 3;
                    break;
                case "up":
                    Link.posY =Link.posY+3;

                    break;
                case "down":
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

        public void HandleLinkWeaponEnemyCollsion(IEnemy enemy)
        {
             //fix later ----enemy damage, drop blood or disappear----
             //need add enemy disappear state and a field in enemy class to record the live of the enemy 
        }
        public void HandleLinkNpcCollsion()
        {
            link.ChangeToStand();
            //may need to draw something on the screen
            //to show the communication with npc
        }

        public void HandleLinkItemCollsion()
        {
            link.ChangeToStand();
            //may need to let item disappear to represent pick up action 
        }

        public void remainPosition(  string direction)
        {
            
            switch(direction)
              
            {
                case "left":
                    Link.posX++;
                    break;
                case "right":
                    Link.posX--;
                    break;
                case "up":
                    Link.posY--;
                  
                    break;
                case "down":
                    Link.posY++;
                    break;
                
                default:
                    Console.WriteLine("error: no such situation");
                    break;
            }
        }




    }
}
