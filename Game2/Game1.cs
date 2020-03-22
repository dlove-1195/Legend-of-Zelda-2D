using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
 
namespace Sprint2
{

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;


        public IEnemy enemy;
        public IPlayer player;
        public Iitem item;
        public INpc npcs;

        private ILevel level;
 
        private ICollisionDetection linkDetection;
        private ICollisionDetection enemyDetection;


        IController keyboardController;

        public static int WindowWidth = 800;
        public static int WindowHeight = 600;
        public static int seed = 0;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
 
             graphics.IsFullScreen = true;
             graphics.PreferredBackBufferWidth = WindowWidth;
             graphics.PreferredBackBufferHeight = WindowHeight;
             graphics.ApplyChanges();
 
        }

        protected override void Initialize()
        {

            keyboardController = new KeyboardController(this);
            
            IsMouseVisible = true;
            


            base.Initialize();
        }

        protected override void LoadContent()
        {
            Texture2DStorage.LoadAllTextures(Content);
            spriteBatch = new SpriteBatch(GraphicsDevice);
            player = new Link(new Vector2(200,300));
            level = new Level1();
            linkDetection = new LinkCollisionDetection(level, player);
            enemyDetection = new EnemyCollisionDetection(level);
             
          
            

        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {

            player.Update(); 
            //will have mouse controller in the future 
            keyboardController.Update();
            linkDetection.Update();
            enemyDetection.Update();
            level.Update();
            linkDetection = new LinkCollisionDetection(level, player);
            enemyDetection = new EnemyCollisionDetection(level);

            seed++;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
           
           
            level.Draw(spriteBatch);
            player.Draw(spriteBatch);

            spriteBatch.End();
           
            base.Draw(gameTime);
        }
    }
}
