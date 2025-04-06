using System;
using System.Net;
using System.Reflection.Metadata;

public class ListingActivity : Activity
{

    private int _count;
    private List<string> _prompts = new List <string>();

    public ListingActivity(string name, string description) : base(name, description)
    {
        SetName(name);
        SetDescription(description);
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);
        GetRandomPrompt();
        GetListFromUser();
        DisplayEndingMessage();
    }

        public void GetRandomPrompt()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);

        string question = _prompts[randomIndex];

        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($"--- {question} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
    }

    public void GetListFromUser()
    {
        List<string> userAnswers = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(getDuration());

        Console.WriteLine();

        while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string response = Console.ReadLine();
                userAnswers.Add(response);
            }

        _count = userAnswers.Count;

        Console.WriteLine($"You listed {_count} items!");
    }
}