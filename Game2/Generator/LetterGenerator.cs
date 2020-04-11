using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
 
namespace Sprint2
{
    public static class LetterGenerator
    {
        private static Texture2D letterTexture = Texture2DStorage.GetLetterSpriteSheet();
        private static int width = 8;
        private static int height = 9;
        private static Dictionary<char, Vector2> letterMap = new Dictionary<char, Vector2>(){
            {'A', new Vector2 (185,24) }, {'B', new Vector2 (201,24)},
            { 'C',new Vector2 (217,24)},
            { 'D',new Vector2 (233,24)},
            { 'E',new Vector2 (249,24)},
            { 'F',new Vector2 (265,24)},
            { 'G',new Vector2 (25,40)},
            { 'H',new Vector2 (41,40)},
            { 'I',new Vector2 (60,40)},
            { 'J',new Vector2 (73,40)},
            { 'K',new Vector2 (89,40)},
            { 'L',new Vector2 (105,40)},
            { 'M',new Vector2 (120,40)},
            { 'N',new Vector2 (137,40)},
            { 'O',new Vector2 (153,40)},
            { 'P',new Vector2 (169,40)},
            { 'Q',new Vector2 (185,40)},
            { 'R',new Vector2 (201,40)},
            { 'S',new Vector2 (217,40)},
            { 'T',new Vector2 (232,40)},
            { 'U',new Vector2 (249,40)},
            { 'V',new Vector2 (264,40)},
            { 'W',new Vector2 (24,56)},
            { 'X',new Vector2 (40,56)},
            { 'Y',new Vector2 (57,56)},
            { 'Z',new Vector2 (73,56)},
             { ' ',new Vector2 (280,24)}

            };
       
 
        //can only draw sentence in one line
        //fontSize: the size you want it to appear on the screen  (width,height)
        public static void drawSentence(SpriteBatch spriteBatch,String sentence, Vector2 startLoc, Vector2 fontSize)
        {
            int i = 0;
            foreach (char c in sentence)
            { 
                Rectangle sourceRectangle = new Rectangle((int)letterMap[c].X, (int)letterMap[c].Y,width, height );
                Rectangle destinationRectangle = new Rectangle((int)(startLoc.X+fontSize.X*i), (int)startLoc.Y , (int)fontSize.X, (int)fontSize.Y);
                spriteBatch.Draw(letterTexture, destinationRectangle, sourceRectangle, Color.White);
                i++;
            }

        }
        
       
        

    }
}