using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string valueInText = Console.ReadLine();
        int number = int.Parse(valueInText);
        string letter = "";
        string z = "";
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else if (number < 60 && number >= 0)
        {
            letter = "F";
        }
        else
        {
            letter = "invalid number";
        }
        int y = number % 10;
        if (number > 92 || number < 60)
        {
            Console.WriteLine($"Your grade is {letter}");
        }
        else
        {
            if (y >= 7)
                z = "+";
            else if (y >= 3 && y < 7)
                z = "";
            else
                z = "-";
            Console.WriteLine($"Your grade is {letter}{z} ");
        }
        if (number >= 70)
        {
            Console.WriteLine("You approved. Congratulations!");
        }
        else
        {
            Console.WriteLine("You didn't approved but don't give up.");
        }

    }
}