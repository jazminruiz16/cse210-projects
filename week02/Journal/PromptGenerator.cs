/*Supplies random prompts whenever needed.*/
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts { get; private set; }
    public PromptGenerator()
    {
        _prompts = new List<string>();
        StartList();
    }
    private void StartList()
    {
        _prompts.Add("What did I do today?");
        _prompts.Add("How do I feel about today overall?");
        _prompts.Add("What was the highlight of my day?");
        _prompts.Add("What did i learn today?");
        _prompts.Add("Is there anything I wish I had done differently?");
        _prompts.Add("What I am grateful for today?");

    }
    public string SelectPrompt()
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, 6);
        string _prompt = _prompts[randomNumber];
        return _prompt;
    }
    


}