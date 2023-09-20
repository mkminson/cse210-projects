using System;

class Program
{
    static void Main(string[] args)
    {
        //main function should call each function, saving the return values in a variable and passing data to them as needed
        DisplayWelcome();

        string userName = PromptUserName();

        int favoriteNumber = PromptUserNumber();

        int square = SquareNumber(favoriteNumber);

        DisplayResult(userName, square);

    }
        //function to display the message "Welcome to the program!"
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        //function to ask for and return the user's name as a string
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        //function to ask for and return the user's favorite number as an int
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int faveNumber = int.Parse(Console.ReadLine());
            return faveNumber;
        }
        
        //function to accept an interger as a parameter and return that number squared (as an int)
        static int SquareNumber(int favoriteNumber)
        {
            int squared = favoriteNumber * favoriteNumber;
            return squared;
        }

        //function to accept the user's name and the squared number and display them
        static void DisplayResult(string name, int squared)
        {            
            Console.WriteLine($"{name}, the square of your number is {squared}");
        }
    
    
}