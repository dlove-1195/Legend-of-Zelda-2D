using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
   public interface Inpc
    {



          void Update();


         void Draw(SpriteBatch spriteBatch);



         void previousNPC(Game1 game); //FIX LATER

       void nextNPC(Game1 game); //FIX LATER
       

    }
}
