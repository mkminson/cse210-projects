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
        _prompts.Add("What is something I am looking forward to today?");
        _prompts.Add("What are my goals for the comming week?");
        _prompts.Add("What is something I did today to help someone else?");
        _prompts.Add("What is one thing that makes me happy to be alive today?");
        _prompts.Add("What is something I am grateful for today?");
        _prompts.Add("What lessons have I learned over the past week?");

        Random randIndex = new Random();
        int randomPosIndex = randIndex.Next(_prompts.Count); //returns a positive random number

        string currentPrompt = _prompts[randomPosIndex]; //gets the string at the randomized index

        return currentPrompt; //returns the random prompt to the method 
    }
}