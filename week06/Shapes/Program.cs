using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("Red", 12.5);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("Brown", 13.4, 10);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("Blue", 13.2);
        shapes.Add(circle1);        

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");    
        }
    }
}