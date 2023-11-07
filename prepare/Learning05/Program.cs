using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square sq = new Square(5.0, "Blue");
        shapes.Add(sq);

        Rectangle rc = new Rectangle(5.0, 4.0, "Red");
        shapes.Add(rc);

        Circle cr = new Circle(5.0, "Green");
        shapes.Add(cr);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine();
        }
    }
}