using System;
using MiniLib;

namespace Test
{
    static class TestMachine
    {
    
        // Simple test for creating an instance of a Customer class and calling some simple methods.
        public static void TestSimpleClass()
        {
            Customer c = new Customer();
            try{
                c.FirstName="Charles";
                c.LastName = "G";
                c.UpdateEmail("charles@test.com");
                c.UpdateVIP(200.0);
                Console.WriteLine("Congrats!You are a VIP now!");
                Console.WriteLine($"Customer Name: {c.FirstName} {c.LastName}");
                Console.WriteLine($"Loyalty: {c.Loyalty}");              

            } catch (Exception e){
                Console.WriteLine($"Invalid operation: {e.Message}");
            }
        }

        /// Test for class inheritance
        public static void TestClassInheritance()
        {
            Shape shape = new Shape();
            Shape rect = new Rectangle();
            shape.Position.X = 10;
            shape.Position.Y = 100;
            shape.Size.Height = 150;
            shape.Size.Width = 250;

            rect.Position.X = 100;
            rect.Position.Y = 200;
            rect.Size.Height = 250;
            rect.Size.Width = 150;

            // Test polymorphism
            shape.Draw();
            rect.Draw();

            // Test hide
            // The Rectangle's MoveTo function is hidden but its base class' MoveTo function is called in this case
            // unless rect's class type is explicitly declared as Rectangle
            rect.MoveTo(10,10);
        }

        public static void TestGenericClass()
        {
            IShapeCreator<Shape> sc = RectangleShapeFactory.GetInstance();
            var shape = sc.Create();
            var c1 = shape.TransformWithToken("secret_123", (t) => t.GetHashCode());
            Console.WriteLine($"New token:{c1}");
            var c2 = shape.TransformWithToken(98001,(t) => 2*t + 1 );
            Console.WriteLine($"New token:{c2}");
            
        }

        public static void TestEnumerator()
        {
            Shapes shapes = new Shapes();
            shapes[0] = new Shape(10,10,200,200);
            shapes[1] = new Shape(20,20,200,200);
            shapes[2] = new Shape(30,30,300,300);

            foreach(var s in shapes){
                Console.WriteLine(s.ToString());
            }
        }

    }
}