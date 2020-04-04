using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class LinkWinningState:IPlayerstate
    {
        private Link link;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        public LinkWinningState(Link link)
        {
            if (link == null)
            {
                throw new System.ArgumentNullException(nameof(link));
            }
            this.link = link;
            
            IItem Triforce = new TriforcePiece(new Vector2(Link.posX, Link.posY - 30));
            Triforce.Appear = true;
            link.items.Add(Triforce);
            link.linkSprite = new LinkWinningSprite(texture);

        }

        public void Win()
        {
            //already win

        }
        public void ChangeToRight()
        {
           //no move
        }
        public void ChangeToLeft()
        {
            //no move
        }
        public void ChangeToUp()
        {
            //no move
        }
        public void ChangeToDown()
        {
            //alrady down
        }
        public void GetDamaged()
        {
            //no move

        }
        public static int getFaceDirection()
        {
            return 1;
        }
        public void Attack()
        {
            //no move
        }
        public void ChangeToWalk()
        {
            //no move
        }
        public void ChangeToStand()
        {
            //already stand
        }
        public void LinkWithItemUp(int item)
        {
            //no move
        }

        public void LinkWithItemDown(int item)
        {
            link.state = new LinkWithItemDownState(link, item);
        }

        public void LinkWithItemLeft(int item)
        {
            //no move
        }

        public void LinkWithItemRight(int item)
        {
            //no move
        }
    }
}

