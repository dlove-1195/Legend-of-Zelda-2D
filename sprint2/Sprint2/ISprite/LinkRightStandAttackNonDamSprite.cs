using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkRightStandAttackNonDamSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        private int currentFrame;
        private int totalFrames;
        private int i;  // control frames

        public LinkRightStandAttackNonDamSprite(Texture2D texture)
        {
            Texture = texture;
            currentFrame = 0;
            totalFrames = 40;
            i = 1;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
            {
                currentFrame = 0;
            }
            if (currentFrame % 10 == 0 && i < 4)
            {
                i++;
            }
            if (i == 4)
            {
                i = 1;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(Game1.FrameWidth * i, Game1.FrameHeight * 1, Game1.FrameWidth, Game1.FrameHeight);     // determine which frame
            Rectangle destinationRectangle = new Rectangle(Game1.InitialWidth, Game1.InitialHeight, Game1.FrameWidth * 2, Game1.FrameHeight * 2);    // determine location and demension of the current frame

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

    }
}
