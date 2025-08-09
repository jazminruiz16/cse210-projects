using System;
using System.Collections.Generic;

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
        Console.Write("Press enter to continue or type 'quit' to finish: ");
        string question = Console.ReadLine();
        scripture1.SetNewText(reference1.GetDisplayText());
        string newText = scripture1.GetNewText();
        while (question != "quit")
        {
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
                lastRound = 2;
            }
            else
            {
                Console.WriteLine("You entered an incorrect answer, please enter a number between 1 to 3.");
                break;
            }
            string newUnitedText = "";
            if (question == "" && m <= lastRound)
            {
                double wordsToHideDecimals = n * fractionNumber;
                scripture1.SetWordsToHide(Convert.ToInt32(Math.Round(wordsToHideDecimals)));
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
            Console.WriteLine(reference1.GetVerseReference() + ": " + newText);


        }

    }

}