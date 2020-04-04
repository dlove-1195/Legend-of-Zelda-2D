using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
 

namespace Sprint2 {
     
    class StartState: IGameState
    {
      
         
       
        //private Texture2D LinkTexture = Texture2DStorage.GetLinkSpriteSheet();
        private Texture2D LogoTexture = Texture2DStorage.GetLogoSpriteSheet();
        private Texture2D ButtonTexture = Texture2DStorage.GetButtonSpriteSheet();
        private Texture2D StoryTexture = Texture2DStorage.GetZeldaStorySpriteSheet();
        private int timer = 0;
        private Vector2 storyLocation = new Vector2(0, 600);
        private Vector2 buttonLocation = new Vector2(300, 1000);
        public StartState()
        { 
        }

        public void Update()
        {
            timer++;
            if (timer % 2 == 0)
            {
                storyLocation.Y--;
            }

            buttonLocation.Y = 250;
            /*if (timer == 2400)
            {
                buttonLocation.Y = 150;
            }*/
            
            
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            
            //story
            Rectangle sourceStoryRectangle = new Rectangle(0, 0, 256, 240);
            Rectangle destinationStoryRectangle = new Rectangle((int)storyLocation.X, (int)storyLocation.Y, 800,600);
            spriteBatch.Draw(StoryTexture, destinationStoryRectangle, sourceStoryRectangle, Color.White);
            //logo
            Rectangle sourceLogoRectangle = new Rectangle(50, 22, 1092, 1130);
            Rectangle destinationLogoRectangle = new Rectangle(300, 50, 200, 150);
            spriteBatch.Draw(LogoTexture, destinationLogoRectangle, sourceLogoRectangle, Color.White);
            //BUTTON 
            Rectangle sourceButtonRectangle = new Rectangle(17,49, 100, 30);
            Rectangle destinationButtonRectangle = new Rectangle((int)buttonLocation.X, (int)buttonLocation.Y, 200, 100);
            spriteBatch.Draw(ButtonTexture, destinationButtonRectangle, sourceButtonRectangle, Color.White);
        }
    }
}
