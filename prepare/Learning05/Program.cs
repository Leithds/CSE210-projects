using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Square a1 = new Square("Brown", 5);
        Rectangle a2 = new Rectangle("Teal", 3, 5);
        Circle a3 = new Circle("Red", 5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(a1);
        shapes.Add(a2);
        shapes.Add(a3);

        foreach (Shape a in shapes)
        {
            string color = a.GetColor();
            double area = a.GetArea();

            Console.WriteLine($"{color} shape has an area of {area}");
        }
    }
}