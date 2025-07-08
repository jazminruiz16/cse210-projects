using System;

class Program
{
    static void Main(string[] args)
    {
        string question = "yes";
        while (question == "yes")
        {
            Console.WriteLine("Hello World! This is the Exercise3 Project.");
            Console.Write("What is the magic number? ");
            string valueInText = Console.ReadLine();
            int number1 = int.Parse(valueInText);
            int tries = 1;
            Console.Write("What is your guess? ");
            string valueInText2 = Console.ReadLine();
            int number2 = int.Parse(valueInText2);
            while (number2 < number1 || number2 > number1)
            {
                if (number2 < number1)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
                tries = tries + 1;
                Console.Write("What is your guess? ");
                valueInText2 = Console.ReadLine();
                number2 = int.Parse(valueInText2);
            }
            Console.WriteLine($"You guessed it! Tries: {tries}");
            Console.Write("Do you wat to play again? (yes/no): ");
            question = Console.ReadLine();
        }

        Console.WriteLine("Ok. Have a nice day.");

    }
}