using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    class Gear3 : ICommand
    {
        private Game1 myGame;
        public Gear3(Game1 game)
        {
            myGame = game;
        }
        public void Execute()
        {

            Vector2 position = myGame.player.GetPosition();
            int x = (int)position.X;
            int y = (int)position.Y;
            int faceDirection = myGame.player.GetDirection();
            Console.WriteLine("--------------&"+faceDirection+"&--------------");
            if (faceDirection == 0)
            {
                
                myGame.player.LinkWithItemUpState(new Bow(x, y, 0));
                Console.WriteLine("--------------!" + faceDirection + "!--------------");
            }
            if (faceDirection == 1)
            {
                
                myGame.player.LinkWithItemDownState(new Bow(x, y, 1));
                Console.WriteLine("--------------!" + faceDirection + "!--------------");
            }
             if (faceDirection == 2)
            {
                
                myGame.player.LinkWithItemLeftState(new Bow(x, y, 2));
                Console.WriteLine("--------------!" + faceDirection + "!--------------");
            }
            if (faceDirection == 3)
           {
               
                myGame.player.LinkWithItemRightState(new Bow(x, y, 3));
                Console.WriteLine("--------------!" + faceDirection + "!--------------");
            }
        }
    }
}
