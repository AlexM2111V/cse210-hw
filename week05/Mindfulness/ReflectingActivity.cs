using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List <string>();
    private List<string> _questions = new List <string>();
    private List<string> _unusedQuestions = new List <string>();

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        SetName(name);
        SetDescription(description);
    }

    public void Run(){
        DisplayStartingMessage();
        ShowSpinner(5);
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt(){
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need");
        _prompts.Add("Think of a time when you did something truly selfless");

        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);

        string prompt = _prompts[randomIndex];

        return prompt;
    }

    public string GetRandomQuestion()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        if (_unusedQuestions.Count == 0)
        {
            _unusedQuestions = new List<string>(_questions);
        }

        Random random = new Random();
        int randomIndex = random.Next(_unusedQuestions.Count);

        string question = _unusedQuestions[randomIndex];
        _unusedQuestions.RemoveAt(randomIndex);

        return question;
    }

    public void DisplayPrompt(){
        Console.WriteLine($"\nConsider the following prompt:");
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
        Console.Write("\nWhen you have something in mind, press enter to continue.");
        string userInput = Console.ReadLine();

            if (userInput == "")
            {
                Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
                Console.Write("You may begin in: ");
                ShowCountDown(5);
            }
    }
    
    public void DisplayQuestions(){
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(getDuration());

            while (DateTime.Now < endTime)
            {
                Console.WriteLine($"> {GetRandomQuestion()}");
                ShowSpinner(5);
            }
    }
}