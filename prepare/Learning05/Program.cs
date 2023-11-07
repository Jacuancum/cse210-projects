using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Black", 4);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("purple", 7, 8);
        shapes.Add(shape2);

        Circle shape3 = new Circle("yellow", 5);
        shapes.Add(shape3);

        Square shape4 = new Square("green", 6);
        shapes.Add(shape4);

        Rectangle shape5 = new Rectangle("light blue", 9,10);
        shapes.Add(shape5);

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}