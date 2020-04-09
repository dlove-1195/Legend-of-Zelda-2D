using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class Dragon : IEnemy
    {
        public int sparkTimer { get; set; } = 0;
        private int damageTimer = 0;
        public IEnemyState state;
        public bool damage { get; set; }
        public ISprite DragonSprite;
        private int updateDelay = 0;
        private int totalDelay = 100;
        public IItem fire;
        public static Boolean hasFire = false;
        private int fireTimer = 0;


        //the current position of the dragon
        public int posX { get; set; }
        public int posY { get; set; }
        private int seed = 1;

        public Rectangle boundingBox { get; set; } = new Rectangle();
        public int blood { get; set; } = 50;

        private int width = 30;
        private int height = 15;
         
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
        public void GetDamage()
        {
            //none
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
                if (fireTimer == 100)
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
                        width = 15;
                        height = 30;

                        break;
                    case 1:
                        this.ChangeToLeft();
                        width = 30;
                        height = 15;
                        break;
                    case 2:
                        this.ChangeToRight();
                        width = 30;
                        height = 15;
                        break;
                    case 3:
                        this.ChangeToUp();
                        width = 15;
                        height = 30;
                        break;
                    default:
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                        Console.WriteLine("error: no such situation");
#pragma warning restore CA1303 // Do not pass literals as localized parameters
                        break;
                }


                if (damage)
                {
                    damageTimer++;
                    if (damageTimer >= 100)
                    {
                        damage = false;
                    }
                }
                else
                {
                    damageTimer = 0;
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

                projectileRec.Add(fire.BoundingBox);

            }



            return projectileRec;
        }




    }
}
