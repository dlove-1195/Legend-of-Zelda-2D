using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class WallMaterMoveLeftSprite : ISprite
    {
        private Texture2D Texture;
        private int width;
        private int height;
        private int sourceLocX;
        private int sourceLocY;

        private int delay = 0;
        
        private IEnemy WallMaster;
        
        
        public WallMaterMoveLeftSprite(Texture2D texture, IEnemy WallMaster)
        {
            Texture = texture;
            this.WallMaster = WallMaster;
         
        }


        
        public void Update()
        {
            
            delay++;
            width = 14;
            height = 15;
            sourceLocX = 241;
            sourceLocY = 0;
            if (delay > 5 && delay<10)
            {
                width = 16;
                height = 16;
                sourceLocX = 240;
                sourceLocY = 30;
                WallMaster.posX-=8;
            }else if(delay>=10 && delay<=15)
            {
                width = 14;
                height = 15;
                sourceLocX = 241;
                sourceLocY = 0;
                WallMaster.posX-=8;
            }else if(delay>15 && delay < 20)
            {
                width = 16;
                height = 16;
                sourceLocX = 240;
                sourceLocY = 30;
                WallMaster.posX+=8;
            }
            else if(delay>=20 && delay<=25)
            {
                width = 14;
                height = 15;
                sourceLocX = 241;
                sourceLocY = 0;
                WallMaster.posX+=8; 
            }else if (delay > 25 )
            {
                delay = 0;
            }

        
        }



        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
               Rectangle destinationRectangle = new Rectangle(WallMaster.posX , WallMaster.posY, width * 3, height * 3);

                
           spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
               
            }
        }
    }
}