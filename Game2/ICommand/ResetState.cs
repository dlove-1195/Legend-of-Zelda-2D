

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
           
            myGame.item = new Heart(new  Vector2(0,0));
           
            myGame.enemy = new Dragon(new Vector2(0,0 ));
            Dragon.posX = 400;
            Dragon.posY = 200;

             
        }
    }
}
