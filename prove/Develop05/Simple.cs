using System;

public class Simple : Goal
{
    public Simple()
    {
        _type = "SimpleGoal";
    }
    public Simple(string name, string description, int points, bool completed) : base(name, description, points, completed)
    {
        _type = "SimpleGoal";
    }
    public override int RecordEvent()
    {
        _completed = true;
        Console.WriteLine($"Congratulations! You have earned {_goalPoints} points!");
        return _goalPoints;
    }
    public override bool IsComplete()
    {
        return base.IsComplete();
    }
    public override string SaveFileString()
    {
        return _type + ":" + _goalName + ":" + _goalDescription + ":" + _goalPoints + ":" + _completed;
    }
}