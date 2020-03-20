using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class Rope : IEnemy
    {

        public IEnemyState state;
        public ISprite RopeSprite;
        public int updateDelay = 0;
        public int totalDelay = 30;



        //the current position of the Keese
        public int posX { get; set; }
        public int posY { get; set; }
         

        private int width = 16;
        private int height = 8;
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
                        Console.WriteLine("HAVE ROPE DOWN");

                        break;
                    case 1:
                        this.ChangeToLeft();
                        Console.WriteLine("HAVE ROPE LEFT");


                        break;
                    case 2:
                        this.ChangeToRight();
                        Console.WriteLine("HAVE ROPE RIGHT ");
                        break;
                    case 3:
                        this.ChangeToUp();
                        Console.WriteLine("HAVE ROPE UP");


                        break;
                    default:
                        Console.WriteLine("error: no such situation");
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
