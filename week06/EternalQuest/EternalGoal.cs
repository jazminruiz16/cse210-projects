public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
       
    }

    public override void RecordEvent()
    {
        Console.WriteLine("Congratulations! You have earned " + _points + " points!");

    }

    public override bool IsComplete()
    {
        return true;
    }
    public override string GetDetailsString(int number)

    {
        return "";


    }
    public override string GetStringRepresentation()
    {
        _description = "SimpleGoal:," + _shortName + "," + _description + "," + _points;
        return _description;
    }
}
