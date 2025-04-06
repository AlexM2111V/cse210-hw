using System;
using System.ComponentModel;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name,description)
    {
        SetName(name);
        SetDescription(description);
    }

    public void Run(){
        DisplayStartingMessage();
        ShowSpinner(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(getDuration());

            while (DateTime.Now < endTime)
            {
                Console.Write("\nBreathe in...");
                ShowCountDown(5);
                Console.Write("\nNow breathe out...");
                ShowCountDown(5);
                Console.WriteLine();
            }

        DisplayEndingMessage();
    }
}