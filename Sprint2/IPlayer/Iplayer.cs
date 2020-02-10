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
        void Update();
        void Draw(SpriteBatch spriteBatch);

        
    }
}
