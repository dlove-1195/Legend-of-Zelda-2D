﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface ILevel
    {
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
