/*Mantiene un registro de la información del libro, capítulo y versículo.*/
public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private string _text;
    public Reference(string book, int chapter, int startVerse, int endVerse, string text)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _text = text;
    }
    public string GetVerseReference()
    {
        string verseReference = "";

        if (_endVerse == 0)
        {
            verseReference = _book + " " + _chapter + " : " + _startVerse;
        }
        else
        {
            verseReference = _book + " " + _chapter + " : " + _startVerse + " - " + _endVerse;
        }
        
        return verseReference;
    }
    public string GetDisplayText()
    {
        return _text;
    }
}