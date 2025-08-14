using System.Threading;
using System.Threading.Tasks;
public class ReflectingActivity : Activity
{
    private int _durationTimeR;
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _durationTimeR = duration;
        _prompts = new List<string>();
        StartList();
        _questions = new List<string>();
        StartListQuestions();

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
    private void StartListQuestions()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        _questions.Add("How did you change emotionally or mentally as a result of this?");
        _questions.Add("Would you do anything differently if you could relive the experience? Why or why not?");
        _questions.Add("What advice would you give to someone facing a similar situation?");
        _questions.Add("What does this experience reveal about your values?");
        _questions.Add("How did others respond to your actions?");
        _questions.Add("What strengths did you demonstrate during this experience?");
        _questions.Add("Have you ever faced something similar before? How was this time different?");

    }
    public string GetRadomQuestion()
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, 8);
        string _question = _questions[randomNumber];
        return _question;
    }
    public void Run()
    {
        _durationTimeR = DisplayingStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");

        ShowSpinner(10);
        Console.WriteLine("Consider de following prompt: ");

        Console.WriteLine("--- " + GetRadomPrompt() + " ---");
        Console.Write("When you have something in mind, press enter to continue: ");
        string youAreReady = Console.ReadLine();
        while (youAreReady != "")
        {
            Console.Write("Please, press enter to continue: ");
            youAreReady = Console.ReadLine();
        }
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
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
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationTimeR);
        while (DateTime.Now < endTime)
        {
            List<string> _mixedQuestions = new List<string>();

            bool verification = true;
            while (verification == true)
            {
                string randomQuestion = GetRadomQuestion();
                bool m = false;
                foreach (string mixedQuestion in _mixedQuestions)
                {
                    if (randomQuestion == mixedQuestion)
                    {
                        m = true;
                    }
                }
                verification = m;
                if (verification == false)
                {
                    _mixedQuestions.Add(randomQuestion);
                    Console.WriteLine(randomQuestion);
                }
            }

            

            Console.WriteLine("");
            ShowSpinner(15);
            
        }
        
    }
}