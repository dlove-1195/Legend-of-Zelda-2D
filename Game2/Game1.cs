using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

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


        IController controller;
        public static int WindowWidth=800;
        public static int WindowHeight=600;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
           
            graphics.PreferredBackBufferWidth = 1200;
            graphics.PreferredBackBufferHeight = 1000;
        }

        protected override void Initialize()
        {

            controller = new KeyboardController(this);
            this.IsMouseVisible = true;
            
             
           
            base.Initialize();
        }

        protected override void LoadContent()
        {
            Texture2DStorage.LoadAllTextures(Content);
            spriteBatch = new SpriteBatch(GraphicsDevice);
            player = new Link();
            enemy = new  Rope();
            item = new Heart();
            npcs = new  Princess();







        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {

            player.Update();
            enemy.Update();
            item.Update();
            npcs.Update();



            controller.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            player.Draw(spriteBatch);

           
            enemy.Draw(spriteBatch);
            item.Draw(spriteBatch);
            npcs.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
