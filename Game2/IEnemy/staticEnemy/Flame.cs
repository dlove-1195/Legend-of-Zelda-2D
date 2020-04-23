using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class Flame : IEnemy
    {
        public int blood { get; set; } = 1;

        private ISprite flameSprite;


        //the current position of the trap
        public int posX { get; set; }
        public int posY { get; set; }

        private int width =16;
        private int height =16;
        public Rectangle boundingBox { get; set; }

        public Flame(Vector2 vector)
        {
            posX = (int)vector.X;
            posY = (int)vector.Y;
            flameSprite = new FlameSilentBurningSprite(Texture2DStorage.GetEnemySpriteSheet2());
        }



        public void ChangeToRight()
        {
            //have no state
        }
        public void ChangeToLeft()
        {
            //have no state
        }
        public void ChangeToUp()
        {
            //have no state
        }
        public void ChangeToDown()
        {
            //have no state
        }
        public void ChangeState(IEnemyState state)
        {
            //have no state

        }

        public void ChangeSprite(ISprite sprite)
        {
            //only one sprite
            
        }



        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
            flameSprite.Update();

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            flameSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public List<Rectangle> getProjectileRec()
        {
            List<Rectangle> projectile = new List<Rectangle>();
            return projectile;
        }


    }
}
