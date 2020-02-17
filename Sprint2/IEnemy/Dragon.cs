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
        public INpc princess;
        public IEnemyState state;
        public ISprite  DragonSprite;
        public int updateDelay = 0;
        public int totalDelay = 30;
        public Iitem fire;


       //the current position of the dragon
        public static int posX = 400;
        public static int posY = 200;
         

       

        public Dragon()
        {

            state = new DragonWalkLeftState(this);
<<<<<<< HEAD
<<<<<<< HEAD
        }

        public void nextNpc(Game1 myGame)
        {
            state = new DragonDisappearState(this);

        }
=======
=======
>>>>>>> ba55c543995b85dd56b6950a590507da5c4f25a7
         }



<<<<<<< HEAD
>>>>>>> ba55c543995b85dd56b6950a590507da5c4f25a7
=======
>>>>>>> ba55c543995b85dd56b6950a590507da5c4f25a7
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

<<<<<<< HEAD
<<<<<<< HEAD
       public void ConnectFire(Fire fire)
        {
            this.fire = fire;
        }
=======

        
>>>>>>> ba55c543995b85dd56b6950a590507da5c4f25a7
=======

        
>>>>>>> ba55c543995b85dd56b6950a590507da5c4f25a7

        public void Update()
        {
            DragonSprite.Update();
            if(fire!= null)
            {
                fire.Update();
            }
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
            DragonSprite.Draw(spriteBatch, new Vector2(posX, posY));
            if (fire != null)
            {
                fire.Draw(spriteBatch);
            }
        }

       


       


    }
}
