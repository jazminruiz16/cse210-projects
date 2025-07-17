using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
class Journal
{
    static List<Entry> entries = new List<Entry>();
    static void Main(string[] args)
    {

        string question = "0";
        while (question != "5")
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Entry e1 = new Entry();
            Console.Write("What would you like to do? ");
            question = Console.ReadLine();
            if (question == "1")
            {
                PromptGenerator generator = new PromptGenerator();
                e1._promptText = generator.SelectPrompt();
                Console.WriteLine($" {e1._promptText}");
                Console.Write(" ");
                e1._journal = Console.ReadLine();
                e1._date = DateTime.Now.ToString("dd/MM/yyyy");
                entries.Add(e1);
                Console.WriteLine($" {entries}");
                foreach (Entry e in entries)
                {
                    Console.WriteLine($"{entries}");
                }

            }
            else if (question == "2")
            {
                foreach (Entry e in entries)/*dentro esa lista aun tienen los nombres e._date*/
                {
                    e.Display();
                }

            }
            else if (question == "3")
            {
                Console.Write("Enter the name of your file: ");
                string fileName = Console.ReadLine();
                LoadToFile(fileName);
            }
            else if (question == "4")
            {
                Console.Write("Enter the name of your file: ");
                string fileName = Console.ReadLine();
                SaveToFile(fileName);

            }
            else if (question == "5")
            {
                Console.WriteLine("Cogratulations! You accomplished today's goal of writing your journal.");

            }
            else
            {
                Console.WriteLine("Please enter a number between 1 to 5 without adding symbols or letters.");
            }
        }

    }

    public static void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in entries)
            {
                outputFile.WriteLine($"{e._date} ~~ Prompt: {e._promptText} ~~ {e._journal}");
            }
        }
    }
    public static void LoadToFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            entries.Clear();
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split("~~");
                Entry e0 = new Entry();
                e0._date = parts[0];
                e0._promptText = parts[1];
                e0._journal = parts[2];
                entries.Add(e0);
            }        
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}