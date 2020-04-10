namespace Sprint2
{
    public class SwitchToWinCommand : ICommand
    {
        private Game1 myGame;
        public SwitchToWinCommand(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.playState = null;
            myGame.gameState = new WinState(myGame);
        }
    }
}