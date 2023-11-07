using System;
using System.Drawing;
using System.Formats.Asn1;

//Add the color member variable and a getter and setter for it.
//Create a constructor that accepts the color and sets it.
//Create a virtual method for GetArea().
public abstract class Shape
{
    private string _color;
    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
    // public double area;
    // public virtual double GetArea()
    // {
    //     return area;
    // }
}