using Microsoft.Xna.Framework.Graphics; 
using Microsoft.Xna.Framework;



namespace Sprint2
{
    public class PlayState : IGameState
    {
        
        private Viewport topViewport;
        private Viewport bottomViewport;

        private Texture2D inventoryTexture = Texture2DStorage.GetInventorySpriteSheet();
        private static int width = 601;
        private static int height = 523;
       
        public IPlayer player; 
        public ILevel level;
        
        public ICollisionDetection linkDetection;
        public ICollisionDetection enemyDetection;


        private IInventory inventoryBar;

        public string name { get; set; }
        private IController playStateController; 
        public PlayState(Game1 game)
        {
            name = "play";
            player = new Link(new Vector2(200, 500)); 
            level = new Level1(player);
            //edit for inventory
            inventoryBar = new Inventory(this);
            //edit for inventory
            linkDetection = new LinkCollisionDetection(level, player);
            enemyDetection = new EnemyCollisionDetection(level);
            playStateController = new PlayStateController( game,this);

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            
            //draw inventory in the topView 
            Rectangle sourceRectangle1 = new Rectangle(0, height - 120, width, Game1.WindowHeight / 4);          
            Rectangle destinationRectangle = new Rectangle(0, 0, Game1.WindowWidth, Game1.WindowHeight/4);
            topViewport = new Viewport(destinationRectangle);
           
            spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
            inventoryBar.Draw(spriteBatch);


            bottomViewport = new Viewport(new Rectangle(Game1.WindowWidth, Game1.WindowHeight / 4, Game1.WindowWidth, Game1.WindowHeight));
            level.Draw(spriteBatch);
            player.Draw(spriteBatch);
            
        }

        public void Update()
        {
            playStateController.Update();
            player.Update();
            linkDetection.Update();
            enemyDetection.Update();
            level.Update();
            linkDetection = new LinkCollisionDetection(level, player);
            enemyDetection = new EnemyCollisionDetection(level);
        }

      
        
    }
}
