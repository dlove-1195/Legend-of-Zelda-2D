﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class Stalfos : IEnemy
    {
        private StaticSprite cloudSprite = new StaticSprite(Texture2DStorage.GetCloudSpriteSheet(), 110, 9, 14, 14);
        private StaticSprite sparkSprite = new StaticSprite(Texture2DStorage.GetLinkSpriteSheet(), 209, 282, 17, 21);
        private int drawCloud = 0;
        private Vector2 initialPos;
        public int sparkTimer { get; set; } = 0;
        private IEnemyState state;
        private ISprite StalfosSprite;
        private int updateDelay = 0;
        private int totalDelay = 30;
        public int blood { get; set; } = 2;
        public bool damage { set; get; }
        private int damageTimer = 0;


        //the current position of the Keese
        public int posX { get; set; }
        public int posY { get; set; }

        private int width = 16;
        private int height = 16;

        public Rectangle boundingBox { get; set; }
        private int enemyNumber = 1;
        private int seed = 1;

        public Stalfos(Vector2 vector)
        {
           
            posX = (int)vector.X;
            posY = (int)vector.Y;
            state = new EnemyWalkLeftState(this, enemyNumber);
            initialPos = new Vector2(posX, posY);
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

        public void GetDamage()
        {
            if (Link.ifDamage && !damage)
            {
                blood--;
                damage = true;
            }
            else if (!damage)
            {
                blood -= 2;
                damage = true;
            }
        }


        public void Update()
        {
            if (damage)
            {
                damageTimer++;
                if (damageTimer >= 50)
                {
                    damage = false;
                }
            }
            else
            {
                damageTimer = 0;
            }
            drawCloud++;
            if (Level1.roomUpdate)
            {
                boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
                StalfosSprite.Update();

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
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                            Console.WriteLine("error: no such situation");
#pragma warning restore CA1303 // Do not pass literals as localized parameters
                            break;
                    }

                }
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
                sparkSprite.Draw(spriteBatch, new Vector2(posX, posY));
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
                    StalfosSprite.Draw(spriteBatch, new Vector2(posX, posY));
                }
            }
 
        }

        public List<Rectangle> getProjectileRec()
        {
            List<Rectangle> projectile = new List<Rectangle>();
            return projectile;
        }
    }
}
