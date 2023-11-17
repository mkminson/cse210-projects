using System;
using System.ComponentModel.DataAnnotations;

public abstract class Goal
{
    protected string _goalName = "";
    protected string _goalDescription = "";
    protected int _goalPoints = 0;
    protected bool _completed = false;
    protected string _type = "";
    public Goal()
    {

    }
    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
    }
    public Goal(string name, string description, int points, bool completed)
    {
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
        _completed = completed;
    }
    public virtual void SetGoalAttributes()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is the description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
    }
    public virtual void DisplayGoal()
    {
        if (_completed == true)
        {
            Console.Write("[X] ");
        }
        else
        {
            Console.Write("[ ] ");
        }
        Console.WriteLine($"{_goalName} ({_goalDescription})");
    }
    public virtual int RecordEvent()
    {
        return _goalPoints;
    }
    public virtual Boolean IsComplete()
    {
        return false;
    }
    public string GetName()
    {
        return _goalName;
    }
    public virtual string SaveFileString()
    {
        return _type + ":" + _goalName + ":" + _goalDescription + ":" + _goalPoints;
    }
}