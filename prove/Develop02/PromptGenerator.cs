using System;

public class PromptGenerator
{
    //create and add items to a list of prompts
    public static List<string> _prompts = new();
    
    public static string PromptRandomizer()
    {
        _prompts.Add("Who was the most intersteing person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");

        Random randIndex = new Random();
        int randomPosIndex = randIndex.Next(_prompts.Count); //returns a positive random number

        string currentPrompt = _prompts[randomPosIndex]; //gets the string at the randomized index

        return currentPrompt; //returns the random prompt to the method 
    }
}