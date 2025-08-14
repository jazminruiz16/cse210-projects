public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted = _amountCompleted+1;
        Console.WriteLine("Congratulations! You have earned " + _points + " points!");

    }

    public override bool IsComplete()
    {
        return true;
    }
    public override string GetDetailsString(int amountCompleted)

    {
        _amountCompleted = amountCompleted;
        string detailString = Convert.ToString(amountCompleted);

        /*string isCompleteVerification = _isComplete ? "[X]" : "[ ]";
        return isCompleteVerification + " " + _shortName + " ( " + _description + ") ";*/
        /*string detailsString = "-- Currently completed: " + _amountCompleted + "/" + _target;*/
        return detailString;
    }
    public override string GetStringRepresentation()
    {
        _description = "ChecklistGoal:," + _shortName + "," + _description + "," + _points+","+_bonus+","+_target+","+_amountCompleted;
        return _description;
    }
}
