 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class TrapSprite : ISprite
    {
        public Texture2D Texture;
        private int width;
        private int height;
        private int sourceLocX;
        private int sourceLocY;
        public IEnemy Trap;
        public TrapSprite(Texture2D texture, IEnemy enemy)
        {
            Texture = texture;
            Trap = enemy;
        }


        public TrapSprite()
        {
            //another constructor, show nothing
        }
        public void Update()
        {

            width = 8;
            height = 14;
            sourceLocX = 326;
            sourceLocY = 241;

        }



        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
                Rectangle destinationRectangle = new Rectangle(Trap.posX, Trap.posY, width * 3, height * 3);


                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            }
        }
    }
}