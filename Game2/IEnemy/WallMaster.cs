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
        private int updateDelay = 0;
        private int totalDelay = 100;
        public bool damage { set; get; }


        //the current position of the dragon
        public int posX { get; set; }
        public int posY { get; set; }
        public Rectangle boundingBox { get; set; }
        private int width = 14;
        private int height = 15;
        public int blood { get; set; } = 50;

        public WallMaster(Vector2 vector )
        {
            posX = (int)vector.X;
            posY = (int)vector.Y;
            state = new WallMasterLeftStaticState(this);
            boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
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
        public void GetDamage()
        {
            //none
        }

        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
            WallMasterSprite.Update();
            updateDelay++;
            if (updateDelay == 10)
            {

                 this.ChangeToLeft(); 
            }else if(updateDelay == 40)
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
