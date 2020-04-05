using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;



namespace Sprint2
{
    public class PlayState : IGameState
    {
        
        private Viewport topViewport;

        private Texture2D inventoryTexture = Texture2DStorage.GetInventorySpriteSheet();
        private static int width = 601;
        private static int height = 523;
       
        public IPlayer player;
       // public IItem item;
       // public INpc npcs;
        public ILevel level;
        public ICollisionDetection linkDetection;
        public ICollisionDetection enemyDetection;
    // Rectangle sourceRectangle2 = new Rectangle(Game1.WindowHeight/4, 0, Game1.WindowWidth, (Game1.WindowHeight*3)/4);
        public PlayState()
        {
            
            player = new Link(new Vector2(200, 500));
           // this.player = player;
            
            level = new Level1();
            linkDetection = new LinkCollisionDetection(level, player);
            enemyDetection = new EnemyCollisionDetection(level);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            
            //draw inventory in the topView
            // Rectangle sourceRectangle1 = new Rectangle(0, 0, width, height-100);
            Rectangle sourceRectangle1 = new Rectangle(0, height - 120, width, Game1.WindowHeight / 4);
            topViewport = new Viewport(sourceRectangle1);
            Rectangle destinationRectangle = new Rectangle(0, 0, Game1.WindowWidth, Game1.WindowHeight/4);
            spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
            

            
            level.Draw(spriteBatch);
            player.Draw(spriteBatch);
            
        }

        public void Update()
        {
            
            player.Update();
            linkDetection.Update();
            enemyDetection.Update();
            level.Update();
            linkDetection = new LinkCollisionDetection(level, player);
            enemyDetection = new EnemyCollisionDetection(level);
        }
    }
}
