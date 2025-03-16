using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _motivationLevel;
    public void Display()
    {
        Console.WriteLine($"\nDate: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine($"My level of motivation at this point is {_motivationLevel}");
    }
}