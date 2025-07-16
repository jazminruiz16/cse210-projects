/*Stores a list of journal entries. SaveToFile and LoadFromFile
Adding an entry
Displaying all the entries
Saving to a file
Loading from a file*/
using System;
using System.Collections.Generic;

class Journal
{
    static void Main(string[] args)
    {
        List<string> numbers = new List<string>();
        string question = "0";
        while (question != "5")
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string question = Console.ReadLine();
            if (question == "1")
            {
                _prompt = PromptGenerator();
                Console.WriteLine($" {_prompt}");
                Console.Write(" ");
                string _journal1 = Console.ReadLine();
            }
            else if (question == "2")
            {

            }
            else if (question == "3")
            {
                letter = "C";
            }
            else if (question == "4")
            {
                letter = "D";
            }
            else if (question == "5")
            {
                letter = "F";
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 5 without adding symbols or letters.");
            }
        }

    }
    public static void SaveToFile(List<)
}