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
        private Vector2 position = new Vector2(200, 200);
         
        // ?? change later 
        public static int currentFrame;
         

       

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


       

        public void Update()
        {
            DragonSprite.Update();

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            DragonSprite.Draw(spriteBatch, position);
        }

        public void RandomStateGenerator()
        {
            //a timer or random number generator, ?? change later
            this.ChangeToDown();
            this.ChangeToLeft();
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
