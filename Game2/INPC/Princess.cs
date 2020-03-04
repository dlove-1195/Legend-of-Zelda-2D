using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
 

namespace Sprint2
{
    public class Princess: Inpc 
    {

       
        public ISprite PrincessSprite;
        private Texture2D texture = Texture2DStorage.GetNpcSpriteSheet();
        public Princess()
        {

            //initial sprite
            PrincessSprite = new StaticSprite(texture, 121, 5, 14, 26);
        }

       

        
        public void Update()
        {
            PrincessSprite.Update();


        }

        public void Draw(SpriteBatch spriteBatch)
        {
            PrincessSprite.Draw(spriteBatch, new Vector2(400, 120));
        }


        public void previousNPC(Game1 game)
        {
            
        }
        public void nextNPC(Game1 game)
        {
             
        }



    }
}
