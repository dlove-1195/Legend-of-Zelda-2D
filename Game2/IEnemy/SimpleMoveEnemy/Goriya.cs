using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class Goriya : IEnemy
    {

        
        public bool damage { get; set; }
        private IEnemyState state;
        private ISprite GoriyaSprite;
        private int updateDelay = 0;
        private int totalDelay = 90;
        public int posX { get; set; }
        public int posY { get; set; }


        
        private int enemyNumber = 2;

        private int width = 16;
        private int height = 16;
        
        public Rectangle boundingBox { get; set; }
        public int  blood { get; set; } = 1;


        public Goriya(Vector2 vector)
        {
            posX = (int)vector.X;
            posY = (int)vector.Y;
            state = new EnemyWalkLeftState(this, enemyNumber);
        }

        public void ChangeState(IEnemyState state)
        {
            this.state = state;
        }

        public void ChangeSprite(ISprite sprite)
        {
            this.GoriyaSprite = sprite;
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
            GoriyaSprite.Update();

         
            updateDelay++;
            if (updateDelay == totalDelay)
            {
                updateDelay = 0;
                
                var rnd = new Random(Game1.seed);
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
            GoriyaSprite.Draw(spriteBatch, new Vector2(posX, posY));
 
        }

        public List<Rectangle> getProjectileRec()
        {
            List<Rectangle> projectile = new List<Rectangle>();
            return projectile;
        }
    }
}
