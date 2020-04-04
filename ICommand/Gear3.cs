using System;

namespace Sprint2
{
    public class Gear3 : ICommand
    {
        private Game1 myGame;
        public Gear3(Game1 game)
        {
            myGame = game;
        }
        public void Execute()
        {


            //itemNum 0: arrow
            int itemNum = 0;
            /* direction should have value 0,1,2,3 corresponding to up, down, left, right*/
            int direction = myGame.player.GetDirection();
            switch (direction)
            {
                case 0:
                    myGame.player.SetLinkWithItemUpState(itemNum);
                    break;
                case 1:
                    myGame.player.SetLinkWithItemDownState(itemNum);
                    break;
                case 2:
                    myGame.player.SetLinkWithItemLeftState(itemNum);
                    break;
                case 3:
                    myGame.player.SetLinkWithItemRightState(itemNum);
                    break;
                default:
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                    Console.WriteLine("not gonna happen ");
#pragma warning restore CA1303 // Do not pass literals as localized parameters
                    break;


            }






        }
    }
}
