using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
 
namespace Sprint2
{

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public IEnemy enemy;
        public Iplayer player;
        public Iitem item;
        public Inpc npcs;
 
        public IRoom room;
 
        public ICollisionDetection linkDetection;
        public ICollisionDetection enemyDetection;


        IController keyboardController;
        IController cameraController;
        public ICamera background = new camera("");
        public static int WindowWidth=800;
        public static int WindowHeight=600;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
 
           // graphics.IsFullScreen = false;
             graphics.PreferredBackBufferWidth = WindowWidth;
             graphics.PreferredBackBufferHeight = WindowHeight;
            // graphics.ApplyChanges();
 
        }

        protected override void Initialize()
        {

            keyboardController = new KeyboardController(this);
            this.IsMouseVisible = true;
            


            base.Initialize();
        }

        protected override void LoadContent()
        {
            Texture2DStorage.LoadAllTextures(Content);
            spriteBatch = new SpriteBatch(GraphicsDevice);
            player = new Link();
           
            linkDetection = new LinkCollisionDetection(room, player);
            enemyDetection = new EnemyCollisionDetection(room);

            //ROOM load in camera controller ??  no
            //load original first room in the game class and change room in the controller
            //same as linkDetection and enemyDectection 
            

        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {

            player.Update(); 
            //will have camera and mouse controller in the future 
            keyboardController.Update();
            linkDetection.Update();
            enemyDetection.Update();
            room.Update();
            cameraController.Update();
            background.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            background.Draw(spriteBatch);
            player.Draw(spriteBatch);
            room.Draw(spriteBatch);
 
            spriteBatch.End();
           
            base.Draw(gameTime);
        }
    }
}
