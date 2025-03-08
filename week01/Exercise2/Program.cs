using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int gradePercentage = int.Parse(percentage);

        string letter;

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80 && gradePercentage < 90)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70 && gradePercentage < 80)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60 && gradePercentage < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("You almost did it. Do not give up!");
        }
    }
}