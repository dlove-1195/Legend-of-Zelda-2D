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
        public int totalDelay = 100;


        //the current position of the dragon
        public static int posX  ;
        public static int posY  ;
        public Rectangle boundingBox { get; set; }
        private int width = 14;
        private int height = 15;
       

        public WallMaster(Vector2 vector )
        {
            posX = (int)vector.X;
            posY = (int)vector.Y;
            state = new WallMasterLeftStaticState(this);
        }



        public void ChangeToRight()
        {
            state.ChangeToRight ();
        }
        public void ChangeToLeft()
        {
            state.ChangeToLeft ();
        }
        
        public void ChangeToUp()
        {

        }
        public void ChangeToDown()
        {

        }

        public void ChangeState(IEnemyState state)
        {
            
        }

        public void ChangeSprite(ISprite sprite)
        {
             
        }


        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
            WallMasterSprite.Update();
            updateDelay++;
            if (updateDelay == 20)
            {

                 this.ChangeToLeft();
                
                 

            }else if(updateDelay == 70)
            {
                 
                state = new WallMasterLeftStaticState(this);

            }else if (updateDelay > totalDelay)
            {
                updateDelay = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            WallMasterSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }

        public List<Rectangle> getProjectileRec()
        {
            List<Rectangle> projectile = new List<Rectangle>();
            return projectile;
        }


    }
}
