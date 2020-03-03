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
        public static int WindowWidth;
        public static int WindowHeight;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {

            controller = new KeyboardController(this);
            this.IsMouseVisible = true;
            WindowWidth = graphics.PreferredBackBufferWidth;
            WindowHeight = graphics.PreferredBackBufferHeight;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            Texture2DStorage.LoadAllTextures(Content);
            spriteBatch = new SpriteBatch(GraphicsDevice);
            player = new Link();
            enemy = new Dragon();
            item = new Heart();
            npcs = new Merchant();







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

            player.Draw(spriteBatch);

            spriteBatch.Begin();
            enemy.Draw(spriteBatch);
            spriteBatch.End();

            item.Draw(spriteBatch);
            npcs.Draw(spriteBatch);

            base.Draw(gameTime);
        }
    }
}
