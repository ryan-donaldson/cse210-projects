using System;
using System.Collections.Generic;
namespace Learning05
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(4.5, "Red");
            Rectangle rectangle = new Rectangle(2.5, 3.5, "Green");
            Circle circle = new Circle(5.5, "Blue");

            List<Shape> shapes = new List<Shape>();
            shapes.Add(square);
            shapes.Add(rectangle);
            shapes.Add(circle);


            foreach (Shape s in shapes)
            {
                string color = s.GetColor();
                double area = s.GetArea();

                Console.WriteLine($"The color of the shape is {color} and its area is {area}.");
            }
        }
    }
}
