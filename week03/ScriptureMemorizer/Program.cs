using System;
using System.Formats.Asn1;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Reference firstReference = new Reference("Mosiah", 2, 17);
        Scripture favoriteScripture = new Scripture(firstReference, "When ye are in the service of your fellow beings ye are only in the service of your God");
        //The next two lines are to create a Reference with multiple verses
        //Reference firstReference = new Reference("2 Nephi", 2, 25, 26);
        //Scripture favoriteScripture = new Scripture(firstReference, "Adam fell that men might be; and men are, that they might have joy. And the Messiah cometh in the fullness of time, that he may redeem the children of men from the fall.And because that they are redeemed from the fall they have become free forever, knowing good from evil; to act for themselves and not to be acted upon, save it be by the punishment of the law at the great and last day, according to the commandments which God has given.");
        string answer = "";

        while (answer != "quit")
        {
            Console.Clear();
            Console.WriteLine(favoriteScripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();  // Read the user's input

            if (userInput.ToLower() == "quit")  // Check if the user typed 'quit' (case-insensitive)
            {
                break;  // Exit the loop and terminate the program
            }
            else if (userInput == "")  // Check if the user pressed Enter (empty input)
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
}