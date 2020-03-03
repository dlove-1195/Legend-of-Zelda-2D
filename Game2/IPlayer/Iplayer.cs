using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    
     public interface Iplayer
    {
        //Link();
        //other player constructor
      
        void ChangeToRight();
        void ChangeToLeft();
        void ChangeToUp();
        void ChangeToDown();
        
        void ChangeToStand();
        void ChangeToWalk();
        int GetDirection();
        void ChangeX(int i);

        void GetDamaged();
        void Attack();
        //void LinkWithBomb();
        //void LinkWithSword();
        //add
        void LinkWithItemLeftState(Iitem item);
        void LinkWithItemRightState(Iitem item);
        void LinkWithItemUpState(Iitem item);
        void LinkWithItemDownState(Iitem item);
        //end
        void Update();
        void Draw(SpriteBatch spriteBatch);
        Vector2 GetPosition();
        void SetPosition(int posX, int posY);

    }
}
