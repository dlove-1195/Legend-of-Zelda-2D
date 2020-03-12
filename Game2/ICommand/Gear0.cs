using System;

namespace Sprint2
{
    class Gear0 : ICommand
    {
        private Game1 myGame;
        public Gear0(Game1 game)
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
                    myGame.player.SetLinkWithItemUpState(3);
                    break;
                case 1:
                    myGame.player.SetLinkWithItemDownState(itemNum);
                    myGame.player.SetLinkWithItemDownState(3);
                    break;
                case 2:
                    myGame.player.SetLinkWithItemLeftState(itemNum);
                    myGame.player.SetLinkWithItemLeftState(3);
                    break;
                case 3:
                    myGame.player.SetLinkWithItemRightState(itemNum);
                    myGame.player.SetLinkWithItemRightState(3);
                    break;
                default:
                    Console.WriteLine("not gonna happen ");
                    break;


            }






        }
    }
}
