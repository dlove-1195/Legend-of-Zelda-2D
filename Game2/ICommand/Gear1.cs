using System;
 
namespace Sprint2 
{
    public class Gear1: ICommand
    {
        private PlayState play;
        public Gear1(PlayState play)
        {
            this.play = play;
        }
        public void Execute()
        {


            //itemNum 2: bomb
            int itemNum = 2;
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
