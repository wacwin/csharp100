using System;

namespace MiniLib
{
    class Shape
    {
        public Position Position {get;} = new Position();
        public Size Size {get;} = new Size();

        public Shape(){}

        public Shape(int x, int y, int hight, int width)
        {
            Position.X = x;
            Position.Y = y;
            Size.Height = hight;
            Size.Height = width;            
        }

        public virtual void Draw() => 
            Console.WriteLine($"Default Shape with Position: {Position} and Size: {Size}.");
        
        public virtual void MoveTo(int x, int y)
        {
            Position.X = x;
            Position.Y = y;
            Console.WriteLine($"Move to ({Position.X},{Position.Y})");
        }

        public TResult TransformWithToken<T,TResult>(T token, Func<T,TResult>action)
        {
            var t = action(token);
            Console.WriteLine($"Your shape has been transformed with the token {token}");
            return t;
        }

        public override string ToString()
        {
            return $"(x:{Position.X},y:{Position.Y},h:{Size.Height},w:{Size.Width})";
        }
    }
}