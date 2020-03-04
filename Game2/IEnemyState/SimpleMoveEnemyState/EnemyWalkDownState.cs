﻿using Microsoft.Xna.Framework.Graphics;
using System;
 
namespace Sprint2 
{
    public class EnemyWalkDownState: IEnemyState
    {
        private int number; 
        private IEnemy  enemy;
        private Texture2D texture1 = Texture2DStorage.GetEnemySpriteSheet();
        private Texture2D texture2 = Texture2DStorage.GetEnemySpriteSheet2();
        
        public EnemyWalkDownState(IEnemy enemy, int number)
        {
            this.number = number;
            this.enemy = enemy;
            switch (number)
            {
                case 0:
                    enemy.ChangeSprite(new BatSprite(texture1, "Down"));
                    break;
                case 1:
                    enemy.ChangeSprite(new StalfoSprite(texture2, "Down"));
                    break;
                case 2:

                    enemy.ChangeSprite(new RedGoriyaSprite(texture2, "Down"));
                    break;
                case 3:
                    enemy.ChangeSprite(new ZolSprite(texture1, "Down"));
                    break;
                case 4:
                   
                    enemy.ChangeSprite(new RopeSprite(texture2, "Down"));
                    
                    break;
                default:
                    Console.WriteLine("error: no such situation");
                    break;
            }
        }
        public void ChangeToRight()
        {
            enemy.ChangeState(new EnemyWalkRightState(enemy, number));
        }

        public void ChangeToLeft()
        {
            enemy.ChangeState(new EnemyWalkLeftState(enemy, number));
        }

        public void ChangeToUp()
        {
            enemy.ChangeState(new EnemyWalkUpState(enemy, number));
        }

        public void ChangeToDown()
        {
            // already down 
        }
     
    }
}