using System;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;

//Make sure this class inherits from the base class.
//Create a constructor that accepts the color and the side, and then call the base constructor with the color.
//Create the _side attribute as a private member variable.
//Override the GetArea() method from the base class and fill in the body of this function to return the area.
public class Square : Shape
{
    private double _side = 0;
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
}