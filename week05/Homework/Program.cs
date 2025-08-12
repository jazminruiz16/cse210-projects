using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment = new Assignment("Brigham Young", "topic X");
        string summary0 = assignment.GetSummary();
        Console.WriteLine(summary0);
        MathAssignment mathAssignment = new MathAssignment("Brigham", "topic1", "section1", "15-18");
        string summary = mathAssignment.GetSummary();
        string homeworkList = mathAssignment.GetHomeworkList();
        Console.WriteLine(summary);
        Console.WriteLine(homeworkList);
        WritingAssignment writingAssignment = new WritingAssignment("Brigham2", "topic1", "title1");
        string summary2 = writingAssignment.GetSummary();
        string titleList = writingAssignment.GetWritingTitle();
        Console.WriteLine(summary2);
        Console.WriteLine(titleList);

    }
}