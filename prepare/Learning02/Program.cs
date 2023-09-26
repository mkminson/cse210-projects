using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTItle = "Software Engineer";
        job1._company = "Microsoft";
        Console.WriteLine($"{job1._jobTItle} {job1._company}");
    }
}