using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string option = "";

        while ( option != "4")
        {
            Console.Clear();
            Console.WriteLine($"Menu options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();

            if ( option == "1" ){
                BreathingActivity activity1 = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                activity1.Run();
            }
            else if ( option == "2"){
                ReflectingActivity activity1 = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                activity1.Run();
            }
            else if ( option == "3"){
                ListingActivity activity1 = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                activity1.Run();
            }
            else if ( option == "4"){
                break;
            }
            else {
                Console.Write("\nPlease enter a valid option.");
                Thread.Sleep(500);
            }
        }
    }
}