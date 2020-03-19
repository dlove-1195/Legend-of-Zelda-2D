using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace Sprint2
{
    public class Bomb : Iitem
    {
        private int itemNum = 2;
        public IitemState state;
        public ISprite bombSprite;
        private int delay = 0;
        //initial position closed to link
        public int posX { get; set; }
        public int posY { get; set; }


        private int bombWidth = 8;//sprite width
        private int bombHeight = 14;//sprite height
        public Rectangle boundingBox { get; set; }

        public Bomb(int posX, int posY)
        {

            state = new BombAppearUnExplodeState(this);
            this.posX = posX;
            this.posY = posY;
        }


        public int getItem()
        {
            return itemNum;
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            bombSprite.Draw(spriteBatch, new Vector2(posX, posY));
        }


        public void Update()
        {
             
            bombSprite.Update();

          
            delay++;
            if (delay > 80  )
            {
                bombWidth = 17;
                bombHeight = 21;
                //state.ChangeToExplode();
                state = new BombAppearExplodeState(this);
                boundingBox = new Rectangle(posX, posY, bombWidth * 3, bombHeight * 3);

            }
           


        }

        public void nextItem(Game1 myGame)
        {

        }

        public void preItem(Game1 myGame)
        {

        }

        public void changeState(IitemState state)
        {
            this.state = state;
        }

        public void changeSprite(ISprite sprite)
        {
            this.bombSprite = sprite;
        }
    }
}
