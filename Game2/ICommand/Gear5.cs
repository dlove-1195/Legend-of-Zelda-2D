using System;

namespace Sprint2
{
    class Gear5 : ICommand
    {
        private PlayState play;
        public Gear5(PlayState play)
        {
            this.play = play;
        }
        public void Execute()
        {


            //itemNum 1: candle
            int itemNum = 1;
            /* direction should have value 0,1,2,3 corresponding to up, down, left, right*/
            int direction = play.player.GetDirection();
            switch (direction)
            {
                case 0:
                    play.player.SetLinkWithItemUpState(itemNum);

                    break;
                case 1:
                    play.player.SetLinkWithItemDownState(itemNum);

                    break;
                case 2:
                    play.player.SetLinkWithItemLeftState(itemNum);

                    break;
                case 3:
                    play.player.SetLinkWithItemRightState(itemNum);

                    break;
                default:
                    Console.WriteLine("not gonna happen ");
                    break;


            }





        }
    }
}
