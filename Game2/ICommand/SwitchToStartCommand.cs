 

namespace Sprint2
{
    public class SwitchToStartCommand : ICommand
    {
        private Game1 myGame;
        public SwitchToStartCommand(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.gameState = new StartState(myGame);
        }
    }
}
