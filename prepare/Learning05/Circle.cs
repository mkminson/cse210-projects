using System;
public class Circle : Shape
{
    private double _radius = 0;
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        double area = _radius * _radius * 3.14159265;
        return area;
    }
}