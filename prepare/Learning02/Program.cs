using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._yearStart = 2019;
        job1._yearEnd = 2022;
        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._yearStart = 2022;
        job2._yearEnd = 2023;
        job2.DisplayJobDetails();

        Resume resume = new Resume();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        //resume._jobs[0]._jobTitle;

        resume.DisplayResumeDetails();

    }
}