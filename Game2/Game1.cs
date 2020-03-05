using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Xml;

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
<<<<<<< HEAD
        public IRoom room;
=======
        public ICollisionDetection detection;
>>>>>>> 3fa391ec45cc3c48f9c367ddf57f5ef343d42078


        IController controller;
        public static int WindowWidth=800;
        public static int WindowHeight=600;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
<<<<<<< HEAD
            
            graphics.PreferredBackBufferWidth = 1200;
            graphics.PreferredBackBufferHeight = 1000;
=======
           // graphics.IsFullScreen = false;
             graphics.PreferredBackBufferWidth = WindowWidth;
             graphics.PreferredBackBufferHeight = WindowHeight;
            // graphics.ApplyChanges();
>>>>>>> 3fa391ec45cc3c48f9c367ddf57f5ef343d42078
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
            enemy = new  Keese();
            item = new Heart();
            npcs = new  Princess();
            room = new Room1();

<<<<<<< HEAD
            
=======
            //ROOM load in camera controller ?? 
            //detection = new LinkCollisionDetection(room, player);






>>>>>>> 3fa391ec45cc3c48f9c367ddf57f5ef343d42078
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
<<<<<<< HEAD
            controller.Update();
            room.Update();
=======

           // detection.Update();

            controller.Update();


>>>>>>> 3fa391ec45cc3c48f9c367ddf57f5ef343d42078
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
            room.Draw(spriteBatch);
            base.Draw(gameTime);
        }
    }
}
