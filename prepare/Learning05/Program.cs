using System;
//Create a Square instance, call the GetColor() and GetArea() methods and make sure they return the values you expect.
class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("red", 4);
        Console.WriteLine($"Your square is {square1.GetColor()}");
        Console.WriteLine($"Your square's area is {square1.GetArea()}");

        Rectangle rectangle1 = new Rectangle("blue", 3, 4);
        Console.WriteLine($"Your rectangle is {rectangle1.GetColor()}");
        Console.WriteLine($"Your rectangle's area is {rectangle1.GetArea()}");

        Circle circle1 = new Circle("pink", 2);
        Console.WriteLine($"Your circle is {circle1.GetColor()}");
        Console.WriteLine($"Your circle's area is {circle1.GetArea()}");

        //In your Main method, create a list to hold shapes (Hint: The data type should be List<Shape>).
        //Add a square, rectangle, and circle to this list.
        //Iterate through the list of shapes. For each one, call and display the GetColor() and GetArea() methods.

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}