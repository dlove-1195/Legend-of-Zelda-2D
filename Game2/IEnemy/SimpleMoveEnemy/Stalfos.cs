using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;


namespace Sprint2
{
    public class Stalfos : IEnemy
    {

        public IEnemyState state;
        public ISprite StalfosSprite;
        public int updateDelay = 0;
        public int totalDelay = 30;



        //the current position of the Keese
        public static int posX;
        public static int posY;

        private int width = 16;
        private int height = 8;

        public Rectangle boundingBox { get; set; }
        private int enemyNumber = 1;


        public Stalfos(Vector2 vector)
        {
            vector.X = posX;
            vector.Y = posY;
            state = new EnemyWalkLeftState(this, enemyNumber);
        }

        public void ChangeSprite(ISprite sprite)
        {
            this.StalfosSprite = sprite;
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
            StalfosSprite.Update();

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
            StalfosSprite.Draw(spriteBatch, new Vector2(posX, posY));







        }
    }
}
