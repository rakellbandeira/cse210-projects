using System;

class Program
{
    static void Main(string[] args)
    {      

        List<Shape> shapeList = new List<Shape>();

        Square square = new Square("Yellow", 2);
        shapeList.Add(square);

        Rectangle rectangle = new Rectangle("Blue", 2, 3);
        shapeList.Add(rectangle);

        Circle circle = new Circle("Black", 4);
        shapeList.Add(circle);

        foreach (Shape shape in shapeList)
        {

            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        

        }

        
    }
}
