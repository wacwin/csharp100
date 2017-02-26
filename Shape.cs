using System;

namespace MiniLib
{
    class Shape
    {
        public Position Position {get;} = new Position();
        public Size Size {get;} = new Size();

        public virtual void Draw() => 
            Console.WriteLine($"Default Shape with Position: {Position} and Size: {Size}.");
        
        public virtual void MoveTo(int x, int y)
        {
            Position.X = x;
            Position.Y = y;
            Console.WriteLine($"Move to ({Position.X},{Position.Y})");
        }
    }
}