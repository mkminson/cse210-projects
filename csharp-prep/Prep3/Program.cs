using System;

class Program
{
    static void Main(string[] args)
    {
        //ask the user for a magic number,read it in as a string, convert it to a number
        //Console.Write("What is the magic number? ");
        //string userInput = Console.ReadLine();
        //int magicNumber = int.Parse(userInput);

        //declare variable to store user's answer as to if they want to play again
        string answer;

        //After the game is over, ask the user if they want to play again. Then, loop back and play the 
        //whole game again and continue this loop as long as they keep saying "yes".
        do 
        {
            //Instead of having the user supply the magic number, generate a random number from 1 to 100.
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            //instantiate variable for useses guess
            int guess = 0;

            //instantiate number of guesses variable
            int numberOfGuesses = 0;

            answer = "";
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
                numberOfGuesses++;
            }   while (guess != magicNumber);   

                //Keep track of how many guesses the user has made and inform them of it at the end of the game. 
                Console.WriteLine($"You guessed the number in {numberOfGuesses} guesses.");

                Console.Write("Do you want to play again? ");
                answer = Console.ReadLine();
        } while (answer == "yes");
    }
}