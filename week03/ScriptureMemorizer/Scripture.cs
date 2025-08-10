/*Registra tanto la referencia como el texto de la escritura. Puede ocultar palabras y 
obtener la representación del texto.*/
public class Scripture
{
    private Reference _reference;
    private int _wordsToHide;
    private string _newText;
    /*public Scripture(Reference reference, int wordsToHide)
    {
        _wordsToHide = wordsToHide;
        _reference = reference;
    }*/
    public void SetReference(Reference reference)
    {
        _reference = reference;
    }
    public void SetWordsToHide(int wordsToHide)
    {
        _wordsToHide = wordsToHide;
    }
    public int GetWordsToHide()
    {
        return _wordsToHide;
    }
    public void SetNewText(string newText)
    {
        _newText = newText;
    }
    public string GetNewText()
    {
        return _newText;
    }
    public string HideWords()
    {

        string[] words = _newText.Split(" ");
        if (_wordsToHide != words.Length)
        {
            for (int i = 0; i < _wordsToHide; i++)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(0, words.Length - 1);
                string hiddenWord = words[randomNumber];
                Word word1 = new Word();
                word1.SetWord(hiddenWord);
                if (word1.CheckHiddenWord() == false)
                {
                    words[randomNumber] = word1.Hide(); ;
                }
                else
                {
                    i = i - 1;
                }
            }
        }
        else
        {
            for (int i = 0; i == _wordsToHide; i++)
            {
                string hiddenWord = words[i];
                Word word2 = new Word();
                word2.SetWord(hiddenWord);
                if (word2.CheckHiddenWord() == false)
                {
                    words[i] = word2.Hide(); ;
                }
                else
                {
                    i = i - 1;
                }
            }
        }
        string newUnitedText = GetDisplayText(words);
        return newUnitedText;
    }
    public string GetDisplayText(string[] words)
    {
        string newUnitedText = "";
        foreach (var word in words)
        {
            int finalWord = 0;
            if (words.Length == finalWord)
            {
                newUnitedText = newUnitedText + word;
            }
            else
            {
                newUnitedText = newUnitedText + word + " ";
            }
            finalWord++;
                
        }
        return newUnitedText;
    }

}