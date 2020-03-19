using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class RopeSprite : ISprite
    {
        public Texture2D Texture;
        private int width;
        private int height;
        private int sourceLocX;
        private int sourceLocY;
        private string direction;

        private int delay = 0;
        private int totalDelay = 10;

        private bool movingLeft = true;
        private bool movingRight = true;
        private bool movingUp = true;
        private bool movingDown = true;

        private IEnemy Rope;
        public RopeSprite(Texture2D texture, String initialDirection, IEnemy rope)
        {
            Texture = texture;
            direction = initialDirection;
            Rope = rope;
        }


        public RopeSprite()
        {
            //another constructor, show nothing
        }
        public void Update()
        {
            delay++;
            if (direction == "Left") {
                if (delay >= 5)
                {
                    sourceLocY = 300;
                    sourceLocX = 1;
                    width = 14;
                    height = 15;
                }
                else { 
                 width = 15;
                height = 14;
                sourceLocX = 0;
                sourceLocY = 331;
                }
               
            }
            else if (direction == "Right")
            {
                if (delay >= 5)
                {
                    width = 14;
                    height = 15;
                    sourceLocX = 31;
                    sourceLocY = 330;
                }
                else { 
                width = 15;
                height = 14;
                sourceLocX = 30;
                sourceLocY = 301;
                }
                
            }
            else if (direction == "Down")
            {
                if (delay >= 5) {
                    width = 14;
                height = 15;
                sourceLocX = 1;
                sourceLocY = 301;
                }
                width = 15;
                    height = 14;
                    sourceLocX = 0;
                    sourceLocY = 331;
            }
            else {
                if (delay >= 5)
                {
                    width = 14;
                    height = 15;
                    sourceLocX = 31;
                    sourceLocY = 330;
                }
                else {

                    width = 15;
                    height = 14;
                    sourceLocX = 30;
                    sourceLocY = 301;
                }
                
            }

          if (direction.Equals("Left")) {
                if (movingLeft) {
                    Rope.posX--;
                    if (Rope.posX <= 0) {
                        movingLeft = false;
                    }
                }
            }
            else if (direction.Equals("Right"))
            {
                if (movingRight)
                {
                    Rope.posX++;
                    if (Rope.posX>= 700)
                    {
                        movingRight = false;
                    }
                }
            }
            else if (direction.Equals("Down"))
            {
                if (movingDown)
                {
                    Rope.posY++;
                    if (Rope.posY >= 420)
                    {
                        movingDown = false;
                    }
                }
            }
            else {
                if (movingUp)
                {
                    Rope.posY--;
                    if (Rope.posY <= 0)
                    {
                        movingUp = false;
                    }
                }
            } 

            if (delay == totalDelay)
            {
                delay = 0;
            }

        }



        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
                Rectangle destinationRectangle = new Rectangle(Rope.posX, Rope.posY, width * 3, height * 3);

               
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                
            }
        }
    }
}