using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Shape> shapes = new List<Shape>
        {
            new Square("Red", 6),
            new Rectangle("Blue", 2, 6),
            new Circle("Green", 4)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}
