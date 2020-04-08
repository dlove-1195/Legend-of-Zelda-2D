using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class Rope : IEnemy
    {

        private IEnemyState state;
        private ISprite RopeSprite;
        private int updateDelay = 0;
        private int totalDelay = 30;
        public int blood { get; set; } = 1;



        //the current position of the Keese
        public int posX { get; set; }
        public int posY { get; set; }
         

        private int width = 16;
        private int height = 11;
        private int seed = 1;

        public Rectangle boundingBox { get; set; }

        private int enemyNumber = 4;


        public Rope(Vector2 vector)

        {
            posX = (int)vector.X;
            posY = (int)vector.Y;
            state = new EnemyWalkLeftState(this, enemyNumber);
        }


        public void ChangeSprite(ISprite sprite)
        {
            this.RopeSprite = sprite;
        }

        public void ChangeState(IEnemyState state)
        {
            this.state = state;
        }

        public void ChangeToRight()
        {
            state.ChangeToRight();
        }
        public void ChangeToLeft()
        {
            state.ChangeToLeft();
        }
        public void ChangeToUp()
        {
            state.ChangeToUp();
        }
        public void ChangeToDown()
        {
            state.ChangeToDown();
        }
        public void GetDamage()
        {
            //none
        }



        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
            RopeSprite.Update();

            //random move dragon
            updateDelay++;
            if (updateDelay == totalDelay)
            {
                updateDelay = 0;
                seed++;
                var rnd = new Random(seed);
                int randomNumber = rnd.Next(0, 4);


                switch (randomNumber)
                {
                    case 0:
                        this.ChangeToDown();
#pragma warning disable CA1303 // Do not pass literals as localized parameters
#pragma warning restore CA1303 // Do not pass literals as localized parameters

                        break;
                    case 1:
                        this.ChangeToLeft();
#pragma warning disable CA1303 // Do not pass literals as localized parameters
#pragma warning restore CA1303 // Do not pass literals as localized parameters


                        break;
                    case 2:
                        this.ChangeToRight();
#pragma warning disable CA1303 // Do not pass literals as localized parameters
#pragma warning restore CA1303 // Do not pass literals as localized parameters
                        break;
                    case 3:
                        this.ChangeToUp();
#pragma warning disable CA1303 // Do not pass literals as localized parameters
#pragma warning restore CA1303 // Do not pass literals as localized parameters


                        break;
                    default:
#pragma warning disable CA1303 // Do not pass literals as localized parameters
#pragma warning restore CA1303 // Do not pass literals as localized parameters
                        break;
                }

            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            RopeSprite.Draw(spriteBatch, new Vector2(posX, posY));
 
        }
        public List<Rectangle> getProjectileRec()
        {
            List<Rectangle> projectile = new List<Rectangle>();
            return projectile;
        }
    }
}
