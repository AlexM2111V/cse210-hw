using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running1 = new Running("03/21/2024", 30, 1.56);
        Cycling cycling1 = new Cycling("10/04/2024", 65, 20.5);
        Swimming swimming1 = new Swimming("02/08/2025", 122, 5);
        activities.Add(running1);
        activities.Add(cycling1);
        activities.Add(swimming1);

        foreach ( Activity activity in activities )
        {
            activity.GetSummary();
        }
    }
}