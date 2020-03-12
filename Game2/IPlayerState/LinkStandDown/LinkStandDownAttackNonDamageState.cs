using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Sprint2 { 
   public  class LinkStandDownAttackNonDamageState: Iplayerstate
    {
        private Link link;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        public LinkStandDownAttackNonDamageState(Link link)
        {
            link.linkSprite = new LinkAttackDownSprite(texture);
            this.link = link;
            this.link.ChangeDirection(1);
            Link.ifAttack = true;
          
            
        }
        public void ChangeToRight()
        {
            
            link.state = new LinkStandRightNonAttackNonDamageState(link);
            
        }
        public void ChangeToLeft()
        {
            link.state = new LinkStandLeftNonAttackNonDamageState(link);
           
        }
        public void ChangeToUp()
        {
            link.state = new LinkStandUpNonAttackNonDamageState(link);
          
        }
        public void ChangeToDown(){
            link.state = new LinkStandDownNonAttackNonDamageState(link);
           
        }
        public void GetDamaged()
        {
           //cannot attack and damage at the same time
        }
        public void Attack() {
            if (Link.ifAttack)
            {
                link.state = new LinkStandDownAttackNonDamageState(link);
            }
            else
            {
                link.state = new LinkStandDownNonAttackNonDamageState(link);

            }
        }
        public void ChangeToWalk()
        {
            // cannot walk when attack
        }
        public void ChangeToStand()
        {
            //already stand
        }

      //  public void LinkWithBomb()
        //{
          //  link.state = new LinkDownWithBombState(link);
        //}

        //public void LinkWithSword()
        //{
          //  link.state = new LinkDownWithSwordState(link);
        //}
       

        public void LinkWithItemUp( int item)
        {
            link.state = new LinkWithItemUpState(link, item);
           
        }

        public void LinkWithItemDown(int item)
        {
            link.state = new LinkWithItemDownState(link, item);
        }

        public void LinkWithItemLeft(int item)
        {
            link.state = new LinkWithItemLeftState(link, item);
           
        }

        public void LinkWithItemRight(int item)
        {
            link.state = new LinkWithItemRightState(link, item);
           
        }
    }
}
