using System;
using System.Collections.Generic;
/*Showing Creativity and Exceeding Requirements: To make it more fun, I made the program offer 
three difficulty levels: Easy = 1, Medium = 2, and Hard = 3. 
The more difficult the program, the more words are hidden per turn. 
This adjusts even if you change the writing to a longer one.*/
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello! This is the ScriptureMemorizer Project.");
        Reference reference1 = new Reference("Proverbs ", 3, 5, 0, "Trust in the Lord with all your heart and lean not on your own understanding.");
        Scripture scripture1 = new Scripture();
        scripture1.SetReference(reference1);

        int n = reference1.GetDisplayText().Split(" ").Length;
        int m = 1;

        scripture1.SetNewText(reference1.GetDisplayText());
        string newText = scripture1.GetNewText();
        Console.Write("Determine the degree of difficulty by entering a number from 1 to 3 : ");
        string difficultyString = Console.ReadLine();
        double fractionNumber = 0.3;
        int lastRound = 2;
        int difficulty = Convert.ToInt32(difficultyString);
        if (difficulty == 1)
        {
            fractionNumber = 0.1;
            lastRound = 9;
        }
        else if (difficulty == 2)
        {
            fractionNumber = 0.2;
            lastRound = 4;
        }
        else if (difficulty == 3)
        {
            fractionNumber = 0.3;
            lastRound = 3;
        }
        else
        {
            Console.WriteLine("You entered an incorrect answer, a low difficulty will be assumed.");
        }
        Console.WriteLine(reference1.GetVerseReference() + ": " + newText);
        Console.Write("Press enter to continue or type 'quit' to finish: ");
        string question = Console.ReadLine();
        while (question != "quit" && m <= lastRound + 2)
        {

            string newUnitedText = "";
            if (question == "" && m <= lastRound)
            {
                double wordsToHideDecimals = n * fractionNumber;
                scripture1.SetWordsToHide(Convert.ToInt32(Math.Floor(wordsToHideDecimals)));
                scripture1.SetNewText(newText);
                newUnitedText = scripture1.HideWords();
                m++;

            }
            else if (question == "" && m == lastRound + 1)
            {
                scripture1.SetWordsToHide(n);
                scripture1.SetNewText(newText);
                newUnitedText = scripture1.HideWords();
                m++;
            }
            else if (question == "" && m == lastRound + 2)
            {
                Console.WriteLine("Congratulations!!");
                break;
            }
            else
            {
                Console.WriteLine("You entered an incorrect answer, please press enter to continue or type 'quit' to finish: ");
            }
            newText = newUnitedText;
            Console.Clear();
            Console.WriteLine(reference1.GetVerseReference() + " : " + newText);
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            question = Console.ReadLine();



        }
        Console.WriteLine("Have a nice day!!");

    }

}