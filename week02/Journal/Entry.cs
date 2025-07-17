/*Represents a single journal entry.*/
public class Entry
{
    public string _date;
    public string _promptText;
    public string _journal;
    public void Display()
    {
        Console.WriteLine($"{_date} ~~ {_promptText}");
        Console.WriteLine($"{_journal}");
    } 
   
}