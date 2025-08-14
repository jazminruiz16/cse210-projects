using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;

    }
    public void Start()
    {
        List<string> listedGoals = new List<string>();

        string question = "0";
        while (question != "6")
        {
            
            Console.WriteLine("You have " + _score+" points.");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create a new Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            /*Entry e1 = new Entry();*/
            Console.Write("What would you like to do? ");
            question = Console.ReadLine();
            if (question == "1")
            {
                Console.WriteLine("The types of goals are: ");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. Checklist Goal");

                Console.Write("Wich type of goal would you like to create? ");
                string goalType = Console.ReadLine();
                Console.Write("Wath is the name of your goal? ");
                string goalName = Console.ReadLine();
                Console.Write("Wath is a short description of it? ");
                string goalDescription = Console.ReadLine();
                Console.Write("Wath is the amount of points associated with this goal? ");
                string goalPoints = Console.ReadLine();
                Console.Write("");
                if (goalType == "1")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                    _goals.Add(simpleGoal);
                    listedGoals.Add(simpleGoal.GetStringRepresentation());
                }
                else if (goalType == "2")
                {
                    EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                    _goals.Add(eternalGoal);
                    listedGoals.Add(eternalGoal.GetStringRepresentation());
                }
                else if (goalType == "3")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string timesToBonusString = Console.ReadLine();
                    int timesToBonus = Convert.ToInt32(timesToBonusString);
                    Console.Write("Wath is the bonus for accomplishing it that many times? ");
                    string goalBonusString = Console.ReadLine();
                    int goalBonus = Convert.ToInt32(goalBonusString);
                    ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, timesToBonus, goalBonus);
                    _goals.Add(checklistGoal);
                    listedGoals.Add(checklistGoal.GetStringRepresentation());
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 to 5 without adding symbols or letters.");
                    question = "6";
                }

                /*PromptGenerator generator = new PromptGenerator();
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
                }*/

            }
            else if (question == "2")
            {
                foreach (string goal in listedGoals)/*dentro esa lista aun tienen los nombres e._date*/
                {
                    string[] goalitems = goal.Split(",");
                    if (goalitems[0] == "SimpleGoal:")
                    {
                        string isCompleteVerification = "[ ]";
                        if (goalitems[4] == "True")
                        {
                            isCompleteVerification = "[X]";
                        }
                        Console.WriteLine(isCompleteVerification + " " + goalitems[1] + " ( " + goalitems[2] + ") ");
                    }
                    else if (goalitems[0] == "EternalGoal:")
                    {
                        Console.WriteLine("[ ] " + goalitems[1] + " ( " + goalitems[2] + ") ");
                    }
                    else if (goalitems[0] == "ChecklistGoal:")
                    {
                        string isCompleteVerification = "[ ]";
                        if (goalitems[6] == goalitems[5])
                        {
                            isCompleteVerification = "[X]";
                        }
                        Console.WriteLine(isCompleteVerification + " " + goalitems[1] + " ( " + goalitems[2] + ") " + "-- Currently completed: " + goalitems[5] + "/" + goalitems[6]);
                    }
                }

            }
            else if (question == "3")
            {
                Console.Write("Enter the name of your file: ");
                string fileName = Console.ReadLine();
                SaveToFile(fileName, listedGoals,_score);

            }
            else if (question == "4")
            {
                Console.Write("Enter the name of your file: ");
                string fileName = Console.ReadLine();
                LoadToFile(fileName, listedGoals);
            }
            else if (question == "5")
            {
                Console.WriteLine("The goals are:");
                int n = 1;
                foreach (string goal in listedGoals)
                {
                    string[] goalitemsNames = goal.Split(",");

                    Console.WriteLine(n + ". " + goalitemsNames[1]);
                    n++;
                }
                Console.Write("Select a goal from menu: ");
                string selectedGoalString = Console.ReadLine();
                int selectedGoal = Convert.ToInt32(selectedGoalString);
                string selectedGoalFromList = listedGoals[selectedGoal - 1];
                string[] goalitems = selectedGoalFromList.Split(",");
                if (goalitems[0] == "SimpleGoal:")
                {
                    if (goalitems[4] == "False")
                    {
                        listedGoals[selectedGoal - 1] = goalitems[0] + "," + goalitems[1] + "," + goalitems[2] + "," + goalitems[3] + "," + "True";
                        int pointsToAdd = Convert.ToInt32(goalitems[3]);
                        _score = _score + pointsToAdd;
                        
                    }                    
                    else
                    {
                        Console.WriteLine("You have already completed this goal");

                    }
                    
                }
                else if (goalitems[0] == "EternalGoal:")
                {
                    
                    int pointsToAdd = Convert.ToInt32(goalitems[3]);
                    _score = _score + pointsToAdd;
                }
                else if (goalitems[0] == "ChecklistGoal:")
                {
                    
                    int target = Convert.ToInt32(goalitems[5]);
                    int actualScore = Convert.ToInt32(goalitems[6])+1;
                    if (target > actualScore)
                    {
                        int pointsToAdd = Convert.ToInt32(goalitems[3]);
                        _score = _score + pointsToAdd;
                        listedGoals[selectedGoal - 1] = goalitems[0] + "," + goalitems[1] + "," + goalitems[2] + "," + goalitems[3] + "," + goalitems[4] + "," + target+","+actualScore;
                    }
                    else if (target == actualScore)
                    {
                        int pointsToAdd = Convert.ToInt32(goalitems[4]);
                        _score = _score + pointsToAdd;
                        listedGoals[selectedGoal - 1] = goalitems[0] + "," + goalitems[1] + "," + goalitems[2] + "," + goalitems[3] + "," + goalitems[4] + "," + target + "," + actualScore;
                    }
                    else
                    {
                        Console.WriteLine("You have already completed this goal");
                        
                    }

                    
                }
                

            }
            else if (question == "6")
            {
                Console.WriteLine("Cogratulations! You accomplished today's goal.");

            }
            else
            {
                Console.WriteLine("Please enter a number between 1 to 6 without adding symbols or letters.");
            }
        }

    }

    public void SaveToFile(string fileName, List<string> listedGoals, int score)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(score);
            foreach (string goal in listedGoals)
            {
                outputFile.WriteLine(goal);
            }
        }
    }
    public void LoadToFile(string fileName, List<string> listedGoals)
    {
        if (File.Exists(fileName))
        {
            listedGoals.Clear();
            string[] lines = System.IO.File.ReadAllLines(fileName);
            _score = Convert.ToInt32(lines[0]);
            for (int i = 1; i < lines.Length; i++)
            {
                listedGoals.Add(lines[i]);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}