using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class Trap : IEnemy
    {

        private ISprite trapSprite;

        public int blood { get; set; } = 1;

        //the current position of the trap
        public int posX { get; set; }
        public int posY { get; set; }

        public Rectangle boundingBox { get; set; }
        private int width =8;
        private int height =14;
        public Trap(Vector2 vector)
        {
            posX = (int)vector.X;
            posY = (int)vector.Y;
            trapSprite = new TrapSprite(Texture2DStorage.GetEnemySpriteSheet2(), this);
        }



        public void ChangeToRight()
        {
        }
        public void ChangeToLeft()
        {
        }
        public void ChangeToUp()
        {
        }
        public void ChangeToDown()
        {
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
            trapSprite.Update();

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            trapSprite.Draw(spriteBatch,new Vector2(posX,posY));
        }

        public List<Rectangle> getProjectileRec()
        {
            List<Rectangle> projectile = new List<Rectangle>();
            return projectile;
        }


    }
}
