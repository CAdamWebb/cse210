using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle("green", 1));
        shapes.Add(new Square("Red", 3));
        shapes.Add(new Rectangle("Red", 4, 5.5));
        foreach (Shape i in shapes)
        {
            Console.WriteLine(i._color);
            Console.WriteLine(i.getArea());
        }
    }
}