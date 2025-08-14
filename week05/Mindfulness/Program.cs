/*Demonstrating creativity: For the reflection activity, I added more code so I wouldn't have duplicate questions until I'd reviewed them all*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine("");
        string question = "0";
        while (question != "5")
        {
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            
            Console.Write("What would you like to do? ");
            question = Console.ReadLine();
            /*Console.Write("How long, in seconds, would you like for this sesion? ");
            string timeString = Console.ReadLine();
            int time = Convert.ToInt32(timeString);*/
            Console.Clear();

            if (question == "1")
            {
                BreathingActivity breathing = new BreathingActivity("Breathing activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 30);
                breathing.Run();
                breathing.DisplayingEndingMessage();
                breathing.ShowSpinner(8);

            }
            else if (question == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity("Reflecting activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 30);

                reflecting.Run();
                reflecting.DisplayingEndingMessage();
                reflecting.ShowSpinner(8);
            }
            else if (question == "3")
            {
                ListingActivity listing = new ListingActivity("Listing activity", "", 30);
                listing.Run();
                listing.DisplayingEndingMessage();
                listing.ShowSpinner(8);
            }
            else if (question == "4")
            {
                Console.WriteLine("Cogratulations! You accomplished today's goal of writing your journal.");

            }
            else
            {
                Console.WriteLine("Please enter a number between 1 to 5 without adding symbols or letters.");
            }
        }

    }
    /*Breathing breathing = new Breathing("name", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 30);
        breathing.DisplayingStartingMessage();
        breathing.ShowSpinner(10);
        --string summary = mathAssignment.GetSummary();
        string homeworkList = mathAssignment.GetHomeworkList();
        Console.WriteLine(summary);
        Console.WriteLine(homeworkList);--

    }*/
}