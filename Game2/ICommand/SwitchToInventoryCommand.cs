namespace Sprint2
{
    public class SwitchToInventoryCommand : ICommand
    {
        private Game1 myGame;
        public SwitchToInventoryCommand(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.gameState = new InventoryScreen(myGame);
        }
    }
}