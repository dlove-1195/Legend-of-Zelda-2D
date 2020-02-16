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
        public Fire fire;

        public ISprite wood;
        public ISprite attack;
        Texture2D texture;
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
            fire = new Fire();
            texture = Content.Load<Texture2D>("link");
            attack = new LinkStandDownAttackNonDamageSprite(texture);
            wood = new WoodenSwordDown(texture);
            enemy.ConnectFire(fire);
 
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {

            
            player.Update();
            enemy.Update();
            fire.Update();
            controller.Update();
            attack.Update();
            wood.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            player.Draw(spriteBatch);
            enemy.Draw(spriteBatch);
            fire.Draw(spriteBatch);
            Vector2 vec;
            vec.X = 250;
            vec.Y = 250;
            attack.Draw(spriteBatch,vec);
            wood.Draw(spriteBatch, vec);
            base.Draw(gameTime);
        }
    }
}
