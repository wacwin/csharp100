using System;

namespace MiniLib
{
    class Rectangle : Shape
    {
        public override void Draw() => Console.WriteLine($"Rectangle with Position: {Position} and Size: {Size}.");

        public new void MoveTo(int x, int y)
        {
            Position.X += x;
            Position.Y += y;
            Console.WriteLine($"Move to ({Position.X},{Position.Y})");
        }
    }


}