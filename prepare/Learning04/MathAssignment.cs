using System;
using System.Diagnostics.CodeAnalysis;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problem;

    public MathAssignment(string name, string topic, string section, string problem) : base(name, topic)
    { 
        _textbookSection = section;
        _problem = problem;
    }

    public string GetHomeworkList()
    {
        return base.GetSummary() + "\r\n" + _textbookSection + " " + _problem;
    }
}