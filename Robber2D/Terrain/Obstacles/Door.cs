using Microsoft.Xna.Framework;

namespace Robber2D
{
    class Door : Block
    {
        public Door(Sprite sprite, Rectangle collisionRectangle) : base(sprite, collisionRectangle)
        {
            ID = 2;
        }
    }
}
