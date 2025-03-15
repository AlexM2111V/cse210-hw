using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "GAP";
        job1._jobTitle = "Senior QA";
        job1._startYear = 2015;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Belatrix";
        job2._jobTitle = "Java Dev";
        job2._startYear = 2000;
        job2._endYear = 2010;

        Job job3 = new Job();
        job3._company = "Encora";
        job3._jobTitle = "Automation Engineer";
        job3._startYear = 2010;
        job3._endYear = 2015;

        Resume resume1 = new Resume();
        resume1._name = "Alexander Mendoza";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._jobs.Add(job3);

        resume1.Display();

    }
}