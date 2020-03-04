using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class WallMaster : IEnemy
    {

        public IEnemyState state;
        public ISprite WallMasterSprite;
        public int updateDelay = 0;
        public int totalDelay = 30;


        //the current position of the dragon
        public static int posX = 400;
        public static int posY = 200;




        public WallMaster()
        {

            state = new WallMasterLeftStaticState(this);
        }



        public void ChangeToRightStatic()
        {
            state.ChangeToRightStatic();
        }
        public void ChangeToLeftStatic()
        {
            state.ChangeToLeftStatic();
        }
        public void ChangeToLeftDynamic()
        {
            state.ChangeToLeftDynamic();
        }
        public void ChangeToRightDynamic()
        {
            state.ChangeToRightDynamic();
        }




        public void Update()
        {
            WallMasterSprite.Update();
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
            WallMasterSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }



    }
}
