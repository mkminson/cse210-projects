using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int wholeNumber = 1;

        //create a new list and ask the user to enter numbers
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while(wholeNumber != 0)
        {
            Console.Write("Enter number: ");
            string num = Console.ReadLine();
            wholeNumber = int.Parse(num);
            
            if(wholeNumber != 0)
            {
            numbers.Add(wholeNumber);
            }
        }

        //print out the list
        Console.WriteLine(string.Join(", ", numbers)); 

        //Add up the sum of the numbers in the list
        int total = numbers.Sum();
        Console.WriteLine($"The sum is {total}.");   
        
        //find the average
        int digits = 0;
        foreach (int a in numbers)
        {
            int n = digits++;
        }
        int average = total/digits;
        Console.WriteLine($"The average is {average}.");

        //find the largest number in the list
        int maxNum = numbers.Max();
        Console.WriteLine($"The largest number is {maxNum}.");
    }
}