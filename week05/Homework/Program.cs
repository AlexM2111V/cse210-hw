using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Josh Carter", "Math II");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Linda Wilson", "Profesional Skills", "8.9", "10-18");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Alexander Mendoza", "Programming with classes", "Abstraction");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}