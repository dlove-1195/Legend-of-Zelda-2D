using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class GreenDragon : IEnemy
    {
        public IEnemyState state;
        public ISprite GreenDragonSprite;
         
        public bool damage { get; set; } = false;
        private int updateDelay = 0;
        private int totalDelay = 100;
        public IItem fire;
        public static Boolean hasFire = false;
        private int fireTimer = 0;
        private int damageTimer = 0;
        
        public int blood { get; set; } = 3;

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
            if (!damage)
            {
                blood--;
                state.GetDamaged();
            }
             
        }




        public void Update()
        {
            drawCloud++;

            boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
            GreenDragonSprite.Update();
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
                        Console.WriteLine("error: no such situation");
                        break;
                }
                
            }
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
