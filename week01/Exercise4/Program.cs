using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = 1;
        double totalNumber = 0;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string valueInText = Console.ReadLine();
            number = int.Parse(valueInText);
            totalNumber = totalNumber + number;
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
            
        Console.WriteLine($"The sum is: { totalNumber}");
        int length = numbers.Count;
        double average = totalNumber / length;
        Console.WriteLine($"The average is: {average}");
        int largestNumber = -1;
        int smallestNumber = 1000000;
        numbers.Sort();
        for (int i = 0; i < numbers.Count; i++)
        {
            number = numbers[i];
            
            if (number > largestNumber)
            {
                largestNumber = number;
            }
            if (number > -1 && number < smallestNumber)
            {
                smallestNumber = number;
            }
        }
  
        Console.WriteLine($"The largest number is: { largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");
        Console.WriteLine("The sorted list is:");

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }

    }
}