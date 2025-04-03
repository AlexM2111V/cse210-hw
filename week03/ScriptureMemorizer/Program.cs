using System;
using System.Formats.Asn1;
using System.Net;

class Program
{
    static void Main(string[] args)
    {

        string answer = "";

        Scripture favoriteScripture = GetRandomEntry();

        while (answer != "quit")
        {
            Console.Clear();
            Console.WriteLine(favoriteScripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else if (userInput == "")
            {
                if (favoriteScripture.IsCompletelyHidden())
                {
                    return;
                }
                else
                {
                    favoriteScripture.HideRandomWords(4);
                }
            }
            else
            {
                Console.WriteLine("Invalid input\n");
            }
        }
    }

     static Scripture GetRandomEntry()
    {
        string[] lines = File.ReadAllLines("Scriptures.csv");

        if (lines.Length == 0)
            throw new Exception("File is empty");

        Random random = new Random();

        string randomLine = lines[random.Next(lines.Length)];
        string[] parts = randomLine.Split('~');
        
        string text = (parts[0]);
        string book = parts[1];
        int chapter = int.Parse(parts[2]);
        int verse = int.Parse(parts[3]);

        Reference favoriteReference;

        if (parts[4] != "")
        {
            int endVerse = int.Parse(parts[4]);
            favoriteReference = new Reference(book, chapter, verse, endVerse);
        }
        else
        {
            favoriteReference = new Reference(book, chapter, verse);
        }

        return new Scripture(favoriteReference, text);
    }
}