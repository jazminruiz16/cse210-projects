public class WritingAssignment : Assignment
{
    private string _title;

    // calling the parent constructor using "base"!
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;

    }
    public string GetWritingTitle()
    {
        return "Title: " + _title;
    }
}