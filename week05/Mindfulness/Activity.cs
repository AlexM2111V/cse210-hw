using System;

public class Activity {
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description){
        _name = name;
        _description = description;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public int getDuration(){
        return _duration;
    }

    public void SetDescription(string description){
        _description = description;
    }

    public void DisplayStartingMessage(){
        Console.WriteLine($"\nWelcome to the {_name} activity.");
        Console.WriteLine($"\n{_description}");
        Console.Write($"\nHow long, in seconds, would you like for your session? ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);
        Console.Clear();
        Console.WriteLine("Get ready... ");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds){

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if ( i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds){

        for (int i = seconds; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void DisplayEndingMessage(){
        Console.WriteLine("\nWell done!!!");
        ShowSpinner(5);

        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }

}