﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{
    public class GonePrincess : INpc
    {


        private ISprite PrincessSprite;
        private Texture2D texture = Texture2DStorage.GetNpcSpriteSheet();

        private int posY;
        private int posX;
        private int princessWidth = 14;//sprite width
        private int princessHeight = 26;//sprite height

        public Rectangle boundingBox { get; set; }
        public GonePrincess(Vector2 vector)
        {
            posX = (int)vector.X;
            posY = (int)vector.Y;
            //initial sprite
            PrincessSprite = new StaticSprite(texture, 121, 5, 14, 26);
        }




        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, princessWidth * 3, princessHeight * 3);
            posY-=3;

            PrincessSprite.Update();


        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (posY>200)
            PrincessSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public void Talk()
        {

        }

        public void previousNPC(Game1 game)
        {

        }
        public void nextNPC(Game1 game)
        {

        }



    }
}
