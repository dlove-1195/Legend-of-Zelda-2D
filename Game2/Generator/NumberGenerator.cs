using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
 
namespace Sprint2
{
    public   class NumberGenerator
    {
        private Texture2D numberTexture = Texture2DStorage.GetNumberSpriteSheet();
        private Dictionary<int, Vector2> numMap = new Dictionary<int, Vector2>(){
            {0, new Vector2 (19,19)},
            {1, new Vector2 (34,19)},
            { 2,new Vector2 (50,19)},
            { 3,new Vector2 (66,19)},
            { 4,new Vector2 (82,19)},
            { 5,new Vector2 (96,19)},
            { 6,new Vector2 (110,19)},
            { 7,new Vector2 (125,19)},
            { 8,new Vector2 (141,19)},
            { 9,new Vector2 (156,19)}
            };
        private Vector2 drawLoc;
        private Vector2 numSize = new Vector2(13, 13);
        private Vector2 drawSize = new Vector2(25,25);
        private int num;
        private int y;
        

        public NumberGenerator()
        { 
        }

        //FIX ME later
        public void increment() { num++; }
        public void decrement() { num--; }

        
        //largest number 99;
        public void DrawSingleNumber(SpriteBatch spriteBatch,bool isBar, Vector2 vector, int number) {
            num = number;
            drawLoc = vector;
            if (isBar)
            {
                y = 0;
            }
            else
            {
                y = 600;
            }
            if (num < 10)
            {
                Rectangle sourceRectangle = new Rectangle((int)numMap[num].X, (int)numMap[num].Y, (int)numSize.X, (int)numSize.Y);
                Rectangle destinationRectangle = new Rectangle((int)drawLoc.X, (int)drawLoc.Y+y, (int)drawSize.X, (int)drawSize.Y);
                spriteBatch.Draw(numberTexture, destinationRectangle, sourceRectangle, Color.White);
            }
            else {
                int num2 = num % 10;
                int num1 = num / 10;
                Rectangle sourceRectangle1 = new Rectangle((int)numMap[num1].X, (int)numMap[num1].Y, (int)numSize.X, (int)numSize.Y);
                Rectangle destinationRectangle1 = new Rectangle((int)drawLoc.X, (int)drawLoc.Y+y, (int)drawSize.X, (int)drawSize.Y);

                spriteBatch.Draw(numberTexture, destinationRectangle1, sourceRectangle1, Color.White);

                Rectangle sourceRectangle2 = new Rectangle((int)numMap[num2].X, (int)numMap[num2].Y, (int)numSize.X, (int)numSize.Y);
                Rectangle destinationRectangle2 = new Rectangle((int)drawLoc.X+ (int)drawSize.X, (int)drawLoc.Y+y, (int)drawSize.X, (int)drawSize.Y);

                spriteBatch.Draw(numberTexture, destinationRectangle2, sourceRectangle2, Color.White);

            }
        }

    }
}