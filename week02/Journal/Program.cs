//Author: Alexander Mendoza
//Exceeding Requirements:
// 1. I added more information in the journal entry, I added the level of motivation
// 2. If the user select Display but there is no entries show a message

using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        int answer = 0;

        Journal MyJournal = new Journal();

        Console.WriteLine("\nWelcome to the Journal Program!\n");

        while (answer != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToString("M/d/yyyy");
                PromptGenerator prompt = new PromptGenerator();
                newEntry._promptText = prompt.GetRandomPrompt();
                Console.Write($"\n{newEntry._promptText} ");
                newEntry._entryText = Console.ReadLine();
                //Ask the user their level of motivation
                Console.WriteLine($"How motivated are you to continue writing in this journal? (In a scale from 1 to 10)");
                newEntry._motivationLevel = Console.ReadLine();
                Console.WriteLine();
                MyJournal.AddEntry(newEntry);

            }
            else if (answer == 2)
            {
                //If there is not entry show a message
                if (MyJournal._entries.Count == 0)
                {
                    Console.WriteLine("\nYour journal has no entries, Please select option 1 to add a new entry or option 3 to load a file.\n");
                }
                //If there is one or more entries display the information
                else
                {
                    MyJournal.DisplayAll();
                }
            }
            else if (answer == 3)
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                MyJournal.LoadFromFile(fileName);
            }
            else if (answer == 4)
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                MyJournal.SaveToFile(fileName);
            }
            else if (answer == 5)
            {
                return;
            }

        }

    }
}