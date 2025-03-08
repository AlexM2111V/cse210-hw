using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        int number = 1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            //Add the numbers only if It is not 0
            if (number != 0)
            {
                numbers.Add(number);
            }

        }

        //Calculate the sum of the numbers entered
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");

        //Compute the average of the numbers entered
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine($"The max is: {max}");

        int minPositive = 1000000;

        foreach (int num in numbers)
        {
            if (num > 0 && num < minPositive)
            {
                minPositive = num;
            }
        }

        Console.WriteLine($"The smallest positive number is: {minPositive}");
    }
}