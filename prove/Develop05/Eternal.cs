using System;

public class Eternal : Goal
{
    public Eternal()
    {
        _type = "EternalGoal";
    }
    public Eternal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override int RecordEvent()
    {
        return _goalPoints;
    }

    public override bool IsComplete()
    {
        return base.IsComplete();
    }
}