 using Microsoft.Xna.Framework.Graphics;
 

namespace Sprint2
{
    public interface ICamera
    {
        void Update();
        void Draw(SpriteBatch spriteBatch); 
        bool switchRoom { get; set; }
        string direction { get; set; }
    }
}