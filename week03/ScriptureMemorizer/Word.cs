
/*Realiza un seguimiento de una sola palabra y si se muestra u oculta.*/
public class Word
{
    private string _word;
    public void SetWord(string word)
    {
        _word = word;
    }
    public string Show()
    {
        return _word;
    }
    public bool CheckHiddenWord()
    {
        bool hidden = false;
        int index = _word.IndexOf("_");
        if (index < 0)
        {
            hidden = true;
        }
        return hidden;
    }
    public string Hide()
    {
        string newHiddenWord = "";
        foreach (char letter in _word)
        {
            newHiddenWord = newHiddenWord + "_";
        }
        return newHiddenWord;
    }
}