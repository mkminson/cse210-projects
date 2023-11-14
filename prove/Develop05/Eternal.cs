using System;

public class Eternal : Goal
{
    public Eternal()
    {
        _type = "EternalGoal";
    }
    public Eternal(string name, string description, int points) : base(name, description, points)
    {
        _type = "EternalGoal";
    }
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_goalPoints} points!");
        return _goalPoints;
    }

    public override bool IsComplete()
    {
        return base.IsComplete();
    }
}