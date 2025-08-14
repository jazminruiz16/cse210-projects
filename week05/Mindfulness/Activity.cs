public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public int DisplayingStartingMessage()
    {
        Console.WriteLine("Welcome to the " + _name + "\n" + _description);
        Console.Write("How long, in seconds, would you like for this sesion? ");
        string timeString = Console.ReadLine();
        _duration = Convert.ToInt32(timeString);
        return _duration;
    }
    public void DisplayingEndingMessage()
    {
        Console.WriteLine("Well done");
        ShowSpinner(8);
        Console.WriteLine( "You have completed " + _duration + " seconds of the " + _name);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");


        /*foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }*/
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b\b");
            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }  

}