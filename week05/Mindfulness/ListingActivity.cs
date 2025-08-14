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
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

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