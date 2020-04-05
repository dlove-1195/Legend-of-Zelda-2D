 

namespace Sprint2
{
    public class SwitchToPauseCommand : ICommand
    {
        private Game1 myGame;
        public SwitchToPauseCommand(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.gameState = new PauseState(myGame);
        }
    }
}
