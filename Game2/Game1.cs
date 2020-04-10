using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
 
namespace Sprint2
{

    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch; 

        //responsible for start/pause/win/gameOver state
        public IGameState gameState { get; set; }
        //responsible for play state
        public  PlayState playState { get; set; }




        //IController keyboardController;

        public static int WindowWidth = 800;
        public static int WindowHeight = 800;
        public static int seed = 0;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            //graphics.IsFullScreen = true;
            graphics.PreferredBackBufferWidth = WindowWidth;
            graphics.PreferredBackBufferHeight = WindowHeight;
            graphics.ApplyChanges();
 
        }

        protected override void Initialize()
        {
 
            IsMouseVisible = true; 
            base.Initialize(); 
        }

        protected override void LoadContent()
        {
            Texture2DStorage.LoadAllTextures(Content);
            spriteBatch = new SpriteBatch(GraphicsDevice); 
            gameState = new StartState(this);
            Sound.LoadBGM(Content);
            Sound.PlayMainSong();


        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        { 
            if(gameState!=null)
            { 
                gameState.Update();
            }
           else if (playState != null)
            {
                playState.Update();
            }

            seed++;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin();
            //Draw sequence cannot change for drawing the inventory screen  
            if (playState != null)
            {
                playState.Draw(spriteBatch);
            }
            if (gameState != null)
            {
                gameState.Draw(spriteBatch);
            }
            
          
            spriteBatch.End();
           
            base.Draw(gameTime);
        }
    }
}
