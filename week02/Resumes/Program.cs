using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1= new Job();
        job1._company="IJSUD";
        job1._jobTitle="engineer";
        job1._startYear=2020;
        job1._endYear=2021;
        Console.WriteLine($" jobtiitle: {job1._jobTitle}");


        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        job2.Display();
    }
}