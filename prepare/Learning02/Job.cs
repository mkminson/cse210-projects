using System;

public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _yearStart = 0;
    public int _yearEnd = 0;
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_yearStart}-{_yearEnd}");
    }
}