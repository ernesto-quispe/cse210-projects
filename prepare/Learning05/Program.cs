using System;

class Program
{
    static void Main(string[] args)
    {

        
        Square square = new("Black", 6);

        //Console.WriteLine($"The square shape is : {square.GetColor()} and has an area of {square.GetArea()}.");

        Rectangle rectangle = new("White", 9, 5);

        //Console.WriteLine($"The rectangle shape is : {rectangle.GetColor()} and has an area of {rectangle.GetArea()}.");

        Circle circle = new("Blue", 18);

        //Console.WriteLine($"The circle shape is : {circle.GetColor()} and has an area of {circle.GetArea()}.");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {Math.Round(shape.GetArea(),2)}"); 
        }

    }
}