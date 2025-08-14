using System.Threading;
using System.Threading.Tasks;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private int _durationTimeL;
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _durationTimeL = duration;
        _prompts = new List<string>();
        StartList();
    }
    private void StartList()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

    }
    private string GetRadomPrompt()
    {

        Random rnd = new Random();
        int randomNumber = rnd.Next(0, 3);
        string _prompt = _prompts[randomNumber];
        return _prompt;
    }
    public List<string> GetListFromUser()
    {
        List<string> listUser = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationTimeL);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string itemToAdd = Console.ReadLine();
            listUser.Add(itemToAdd);

        }
        return listUser;
    }
    public void Run()
    {
        _durationTimeL = DisplayingStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");

        ShowSpinner(10);
        Console.WriteLine("List as many responses you can to the following prompt: ");

        Console.WriteLine("--- " + GetRadomPrompt() + " ---");
        Console.Write("You may begin in... ");
        for (int i = 0; i < 9; i++)
        {
            int timeToReady = 9 - i;
            Console.Write(timeToReady);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
        Console.WriteLine("");
        Console.Clear();
        List<string> newListUser = GetListFromUser();
        _count = newListUser.Count();
        Console.WriteLine("You listed " + _count + " items!");
        Console.WriteLine("");
        

    }
}