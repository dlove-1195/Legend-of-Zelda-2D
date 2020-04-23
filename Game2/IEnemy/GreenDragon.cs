using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class GreenDragon : IEnemy
    {
#pragma warning disable CA1051 // Do not declare visible instance fields
        public IEnemyState state;
#pragma warning restore CA1051 // Do not declare visible instance fields
#pragma warning disable CA1051 // Do not declare visible instance fields
        public ISprite GreenDragonSprite;
#pragma warning restore CA1051 // Do not declare visible instance fields

        public bool damage { get; set; } = false;
        private int updateDelay = 0;
        private int totalDelay = 100;
#pragma warning disable CA1051 // Do not declare visible instance fields
        public IItem fire;
#pragma warning restore CA1051 // Do not declare visible instance fields
#pragma warning disable CA2211 // Non-constant fields should not be visible
        public static Boolean hasFire = false;
#pragma warning restore CA2211 // Non-constant fields should not be visible
        private int fireTimer = 0;
        private int damageTimer = 0;
        
        public int blood { get; set; } = 6;

        //the current position of the dragon
        public int posX { get; set; }
        public int posY { get; set; }
        private int seed = 1;

        public Rectangle boundingBox { get; set; } = new Rectangle();

        private int width = 24;
        private int height = 32;

        private StaticSprite cloudSprite = new StaticSprite(Texture2DStorage.GetCloudSpriteSheet(), 110, 9, 14, 14);
        private StaticSprite sparkSprite = new StaticSprite(Texture2DStorage.GetLinkSpriteSheet(), 209, 282, 17, 21);
        private int drawCloud = 0;
        public int sparkTimer { get; set; } = 0;
        private Vector2 initialPos;
       
        public GreenDragon(Vector2 vector)
        {
            posX = (int)vector.X;
            posY = (int)vector.Y;
            initialPos = new Vector2(posX, posY);
            state = new GreenDragonWalkLeftState(this);

            boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
        }


        public void ChangeState(IEnemyState state)
        {
            //no op
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
            //none
        }
        public void ChangeToDown()
        {
            //none
        }
        public void GetDamage()
        {
            if (!damage && Link.ifDamage)
            {
                blood--;
                state.GetDamaged();
            }
            else if(!damage)
            {
                blood -= 2;
                state.GetDamaged();

            }
             
        }




        public void Update()
        {
            drawCloud++;
            GreenDragonSprite.Update();
            if (Level1.roomUpdate)
            {
                boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
              
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
                    int randomNumber = rnd.Next(0, 1); 
                    switch (randomNumber)
                    { 
                        case 0:
                            this.ChangeToLeft();
                            break;
                        case 1:
                            this.ChangeToRight();
                            break;

                        default:
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                            Console.WriteLine("error: no such situation");
#pragma warning restore CA1303 // Do not pass literals as localized parameters
                            break;
                    }

                }
            }
           

                drawCloud++;
                if (damage)
            {
                damageTimer++;
                if (damageTimer >= 150)
                {
                    damage = false;
                }
            }
            else
            {
                damageTimer = 0;
            }

            if (blood <= 0)
            {
                sparkTimer++;
            }


        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (blood <= 0)
            { 
                sparkSprite.Draw(spriteBatch, new Vector2(posX,posY));
            }
            else
            {
                if (drawCloud <= 20)
                {
                    cloudSprite.Draw(spriteBatch, initialPos);
                    posX = (int)initialPos.X;
                    posY = (int)initialPos.Y;
                }
                else
                {
                    GreenDragonSprite.Draw(spriteBatch, new Vector2(posX, posY));
                    if (fire != null)
                    {
                        fire.Draw(spriteBatch);
                    }
                }
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
