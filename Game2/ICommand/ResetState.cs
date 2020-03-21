

using Microsoft.Xna.Framework;

namespace Sprint2 
{
    class ResetState: ICommand
    {
        private Game1 myGame;
        public ResetState(Game1 game)
        {
            myGame = game;
        }
        public void Execute()
        {
           
            myGame.player.ChangeToRight();
            Link.posX = 200;
            Link.posY = 200;
           
           // fix later 
           //reset everything to its original place

             
        }
    }
}
