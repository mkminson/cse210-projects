using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        //ask for number, read in number, and convert it from a string to a number
        Console.Write("What is your grade percentage? ");
        string percentString = Console.ReadLine();
        int percentNumber = int.Parse(percentString);
        string letter;
        string sign = null;

        if (percentNumber >= 90)
        {
            letter = "A";
        }
        else if (percentNumber >= 80)
        {
            letter = "B";
        }
        else if (percentNumber >= 70)
        {
            letter = "C";
        }
        else if (percentNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (percentNumber%10 >= 7)
        {
            sign = "+";
        }
        else if (percentNumber%10 < 3)
        {
            sign = "-";
        }

        if (letter == "A" || letter =="F")
        {
            sign = null;
        }

        Console.WriteLine($"Your grade is {letter}{sign}.");

        if (percentNumber >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you failed the class. Better luck next time!");
        }

        

    }
}