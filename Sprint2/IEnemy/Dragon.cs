using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class Dragon: IEnemy
    {

        public IEnemyState state;
        public ISprite  DragonSprite;
        public int updateDelay = 0;
        public int totalDelay = 30;
        private Fire fire = new Fire();


        // ?? change later 
        private Vector2 position = new Vector2(200, 200);
        public static int currentFrame;
        public static int posX = 400;
        public static int posY = 200;
         

       

        public Dragon()
        {

            state = new DragonWalkLeftState(this);
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


       public void ConnectFire(Fire fire)
        {
            this.fire = fire;
        }

        public void Update()
        {
            DragonSprite.Update();
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
                          fire.ChangeToAppear();
                        
                           break;
                       case 1:
                           this.ChangeToLeft();
                          fire.ChangeToDisappear();
                         
                        break;
                       case 2:
                           this.ChangeToRight();
                          fire.ChangeToAppear();
                        break;
                       case 3:
                           this.ChangeToUp();
                        fire.ChangeToDisappear();
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
        }

       


        //TRACK THE CURRENT STATUS OF THE LINKSPRITE
        public Vector2 GetPosition()
        {
            return position;
        }

        public void SetPosition(int posX, int posY)
        {
            position.X = posX;
            position.Y = posY;
        }


    }
}
