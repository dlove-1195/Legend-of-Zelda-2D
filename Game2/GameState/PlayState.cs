using Microsoft.Xna.Framework.Graphics; 
using Microsoft.Xna.Framework;

//please add inventoryBar.heartNum--; and inventoryBar.itemList.add("item-name"); in link collision handler
//set itemB using inventoryBar object by inventoryBar.itemB = "string"
namespace Sprint2
{
    public class PlayState : IGameState
    {
        
       // private Viewport topViewport;
        //private Viewport bottomViewport;

        private Texture2D inventoryTexture = Texture2DStorage.GetInventorySpriteSheet();
        private static int width = 800;
        private static int height = 871;
       
        public IPlayer player; 
        public ILevel level;
        
        public ICollisionDetection linkDetection;
        public ICollisionDetection enemyDetection;


        public IInventory inventoryBar { get; set; }

        
        private IController playStateController;
        //responsible for switching between playstate to win/lose state
        private IController inventoryController;
        public PlayState(Game1 game)
        { 
            player = new Link(new Vector2(648, 577)); 
            level = new Level1(player); 
            linkDetection = new LinkCollisionDetection(level, player, inventoryBar);
            enemyDetection = new EnemyCollisionDetection(level); 
            Sound.PlayRoom();
            playStateController = new PlayStateController(game, this);
            inventoryController = new InventoryController(game);
            //initialize the inventory here for the first time 

            inventoryBar = new Inventory(this);

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            
             
            Rectangle sourceRectangle1 = new Rectangle(0, height - 200, width, Game1.WindowHeight / 4);          
            Rectangle destinationRectangle = new Rectangle(0, 0, Game1.WindowWidth, Game1.WindowHeight/4);
          
            spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);

            //only draw the bar area
            inventoryBar.barOnly = true;
            inventoryBar.Draw(spriteBatch); 
            level.Draw(spriteBatch);
            player.Draw(spriteBatch);
            
        }

        public void Update()
        {
            playStateController.Update();
            inventoryController.Update();
            player.Update();
            linkDetection.Update();
            //stop update when using clock in order to avoid detection with wall and block, result in changing position
            enemyDetection.Update();
            level.Update();
            linkDetection = new LinkCollisionDetection(level, player, inventoryBar);
             if (level.roomUpdate)
            {
                enemyDetection = new EnemyCollisionDetection(level);
             }

            inventoryBar.Update();

        }

      
        
    }
}
