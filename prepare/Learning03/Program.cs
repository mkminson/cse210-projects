using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(2, 8);

        f4.SetTop(1);
        //Console.WriteLine(f4.GetTop());

        f4.SetBottom(3);
        //Console.WriteLine(f4.GetBottom());

        Console.WriteLine(f1.GetFractionString());  
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());  
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());  
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine(f4.GetFractionString());  
        Console.WriteLine(f4.GetDecimalValue());
    }
}