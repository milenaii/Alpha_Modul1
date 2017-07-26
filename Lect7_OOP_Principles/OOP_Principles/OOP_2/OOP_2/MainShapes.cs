using System;

namespace OOP_2
{
    class MainShapes
    {
        public static void Main()
        {
            Triangle triangle = new Triangle(12, 5);
            Console.WriteLine(triangle.CalculateSurface());

            Rectangle rectangle = new Rectangle(5, 8);
            Console.WriteLine(rectangle.CalculateSurface());

            Square square = new Square(5);
            Console.WriteLine(square.CalculateSurface());

            Shape[] shapes = new Shape[]
                {
                new Rectangle(5.2, 6),
                new Triangle (8, 6.4),
                new Square(5)
                };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0:F2}", shape.CalculateSurface());
            }

        }
    }
}
