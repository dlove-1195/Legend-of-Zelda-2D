using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class Dragon : IEnemy 
    {

        public IEnemyState state;
        public ISprite DragonSprite;
        public int updateDelay = 0;
        public int totalDelay = 100;
        public Iitem fire;
        public static Boolean hasFire = false;
        private int fireTimer = 0;


        //the current position of the dragon
        public int posX { get; set; }
        public int posY { get; set; }
        private int seed = 1;

        public Rectangle boundingBox { get; set; } = new Rectangle();

        private int width =15;
        private int height =16;
        public Dragon(Vector2 vector)
        {
            posX = (int)vector.X;
            posY = (int)vector.Y;
             
            state = new DragonWalkLeftState(this);
            boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
        }


        public void ChangeState(IEnemyState state)
        {
            // no op
        }

        public void ChangeSprite(ISprite sprite)
        {
             //no op
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
            DragonSprite.Update();
            if (fire != null)
            {
                fire.Update();
            }

            if (hasFire)
            {
                fireTimer++;
                if(fireTimer == 100)
                {
                    hasFire = false;
                }
            }
            else
            {
                fireTimer = 0;
                fire = null;
            }
            
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
            
            DragonSprite.Draw(spriteBatch, new Vector2(posX, posY));
            if (fire != null)
            {
                fire.Draw(spriteBatch);
            }
        }

        public List<Rectangle> getProjectileRec()
        {
            List<Rectangle> projectileRec = new List<Rectangle>();
            if (fire != null)
            {

                projectileRec.Add(fire.boundingBox);

            }



            return projectileRec;
        }




    }
}
