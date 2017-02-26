using System;
namespace MiniLib
{
    class RectangleShapeFactory : IShapeCreator<Rectangle>
    {
        private static readonly RectangleShapeFactory _rsf = new RectangleShapeFactory();
        private RectangleShapeFactory()
        {
        }

        public static IShapeCreator<Rectangle> GetInstance()
        {
            return _rsf;
        }
        public Rectangle Create()
        {
            Console.WriteLine("A Rectangle is created...");
            return new Rectangle();
        }

        
    }
}