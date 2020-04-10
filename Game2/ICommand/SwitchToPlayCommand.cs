 

namespace Sprint2
{
    public class SwitchToPlayCommand : ICommand
    {
        private Game1 myGame;
        public SwitchToPlayCommand(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
           
            if (myGame.playState != null  )
            {
                myGame.gameState = null;
            }
            else
            {
                myGame.playState = new PlayState(myGame);
                myGame.gameState = null;
            }
          
        }
    }
}
