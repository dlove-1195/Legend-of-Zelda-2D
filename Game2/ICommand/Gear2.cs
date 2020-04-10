using System;
 
namespace Sprint2 
{
    public class Gear2: ICommand
    {
        private PlayState play;
        private int itemNum; 
        public Gear2(PlayState play,String selectedItem)
        {
            this.play = play;
            itemNum =getItemNum(selectedItem);
        }
        public void Execute()
        {
             
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
        private int getItemNum(String selectItem)
        {
            int i = -1;
            //selected item, can be bomb(2), arrow(0), boomerage(5), candle(1)  
            switch (selectItem)
            {
                case "bomb":
                    i = 2; 
                    break;
                case "arrow":
                    i = 0;
                    break;
                case "candle":
                    i = 1;
                    break;
                case "boomerang":
                    i = 5;
                    break;
                default:
                    Console.WriteLine("not gonna happen ");
                    break;


            }
            return i;
        }

    }
}
