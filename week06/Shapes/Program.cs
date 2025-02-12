using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("Blue", 5,3);
        shapes.Add(r1);

        Circle c1 = new Circle("Green", 2);
        shapes.Add(c1);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Area: {area}");
            
        }
    }
}