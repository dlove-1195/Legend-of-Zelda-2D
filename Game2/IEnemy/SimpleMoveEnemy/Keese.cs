using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class Keese : IEnemy
    {

        public IEnemyState state;
        public ISprite KeeseSprite;
        public int updateDelay = 0;
        public int totalDelay = 30;



        //the current position of the Keese
        public static int posX;
        public static int posY;

        private int enemyNumber = 0;
        private int width = 16;
        private int height = 8;

        public Rectangle boundingBox { get; set; }

        public Keese(Vector2 vector)
        {
            posX = (int)vector.X;
            posY = (int)vector.Y;

            state = new EnemyWalkLeftState(this, enemyNumber);
        }


        public void ChangeSprite(ISprite sprite)
        {
            this.KeeseSprite = sprite;
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




        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
            KeeseSprite.Update();

            //random move dragon
            updateDelay++;
            if (updateDelay == totalDelay)
            {
                updateDelay = 0;

                var rnd = new Random();
                int randomNumber = rnd.Next(0, 4);


                switch (randomNumber)
                {
                    case 0:
                        this.ChangeToDown();


                        break;
                    case 1:
                        this.ChangeToLeft();



                        break;
                    case 2:
                        this.ChangeToRight();

                        break;
                    case 3:
                        this.ChangeToUp();

                        break;
                    default:
                        Console.WriteLine("error: no such situation");
                        break;
                }

            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            KeeseSprite.Draw(spriteBatch, new Vector2(posX, posY));
 
        }
        public List<Rectangle> getProjectileRec()
        {
            List<Rectangle> projectile = new List<Rectangle>();
            return projectile;
        }
    }
}
