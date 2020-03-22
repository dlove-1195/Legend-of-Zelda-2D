using System;

namespace Sprint2
{
    class Gear5 : ICommand
    {
        private Game1 myGame;
        public Gear5(Game1 game)
        {
            myGame = game;
        }
        public void Execute()
        {


            //itemNum 1: candle
            int itemNum = 1;
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
                    Console.WriteLine("not gonna happen ");
                    break;


            }






        }
    }
}
