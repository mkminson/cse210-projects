using System;

class Program
{
    static void Main(string[] args)
    {
        //ask the user for a magic number,read it in as a string, convert it to a number
        //Console.Write("What is the magic number? ");
        //string userInput = Console.ReadLine();
        //int magicNumber = int.Parse(userInput);

        //Instead of having the user supply the magic number, generate a random number from 1 to 100.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        //instantiate guess variable
        int guess = 0;

        //Add Do-While loop that keeps looping as long as the guess does not match the magic number.
        do
        {   //ask the user for a guess, read it in as a string, convert it to a number
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);

            //Using an if statement, determine if the user needs to guess higher or lower next time, 
            //or tell them if they guessed it.

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
                else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
                else
            {
                Console.WriteLine("You guessed it!");
            }
        }   while (guess != magicNumber);     
    }
}