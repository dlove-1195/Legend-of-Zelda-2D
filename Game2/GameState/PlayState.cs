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
        public PlayState(Game1 game)
        { 
            player = new Link(new Vector2(200, 500)); 
            level = new Level1(player);
            //edit for inventory
            //initialize the inventory here for the first time 
            inventoryBar = new Inventory();
            //edit for inventory
            linkDetection = new LinkCollisionDetection(level, player);
            enemyDetection = new EnemyCollisionDetection(level);
            playStateController = new PlayStateController( game,this);
            Sound.PlayRoom();

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
            player.Update();
            linkDetection.Update();
            enemyDetection.Update();
            level.Update();
            linkDetection = new LinkCollisionDetection(level, player);
 
            enemyDetection = new EnemyCollisionDetection(level);

            inventoryBar.Update();

        }

      
        
    }
}
