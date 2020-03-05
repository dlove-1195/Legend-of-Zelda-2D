using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
 

namespace Sprint2
{
    public class Goriya : IEnemy
    {


        public IEnemyState state;
        public ISprite GoriyaSprite;
        public int updateDelay = 0;
        public int totalDelay = 30;



        //the current position of the Keese
        public static int posX = 400;
        public static int posY = 200;

        private int enemyNumber = 2;


        public Goriya()
        {

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




        public void Update()
        {
            GoriyaSprite.Update();

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
            GoriyaSprite.Draw(spriteBatch, new Vector2(posX, posY));







        }
    }
}
