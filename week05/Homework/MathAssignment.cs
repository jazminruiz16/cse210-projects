public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    // calling the parent constructor using "base"!
    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return "Section: " + _textBookSection + " Number: " + _problems;
    }
   /* public string GetStudentName()
    {
        return studentName;
    }*/
}
