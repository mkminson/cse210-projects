using System;

public class Checklist : Goal
{
    private int _bonusPoints = 0;
    private int _bonusTimes = 0;
    private int _timesCompleted = 0;
    public Checklist() : base()
    {
        _type = "ChecklistGoal";
    }
    public Checklist(string name, string description, int points, int bonusPoints, int bonusTimes, int timesCompleted) : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _bonusTimes = bonusTimes;
        _timesCompleted = timesCompleted;
        _type = "ChecklistGoal";
    }
    public override void SetGoalAttributes()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is the description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _bonusTimes = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
    public override void DisplayGoal()
    {
        if (_timesCompleted == _bonusTimes)
        {
            Console.Write("[X] ");
        }
        else
        {
            Console.Write("[ ] ");
        }
        Console.WriteLine($"{_goalName} ({_goalDescription}) -- Currently completed: {_timesCompleted}/{_bonusTimes}");
    }
    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_bonusTimes != _timesCompleted)
        {
            Console.WriteLine($"Congratulations! You have earned {_goalPoints} points!");
            return _goalPoints;
        }
        else
        {
            _completed = true;
            Console.WriteLine($"Congratulations! You have earned {_goalPoints + _bonusPoints} points!");
            return _bonusPoints + _goalPoints;
        }
    }
    public override bool IsComplete()
    {
        return base.IsComplete();
    }
    public override string SaveFileString()
    {
        return _type + ":" + _goalName + ":" + _goalDescription + ":" + _goalPoints + ":" + _bonusPoints + ":" + _bonusTimes + ":" + _timesCompleted;
    }
}