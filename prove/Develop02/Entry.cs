using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _newEntry; 
    
    public void DisplayDatePromptEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt} \r\n{_newEntry}");
    }

    public Entry()
    {
        _date = DateTime.Today.ToShortDateString();
        _prompt = PromptGenerator.PromptRandomizer();
    }
}