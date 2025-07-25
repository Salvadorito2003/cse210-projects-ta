public class Reference
{
    private string _referenceBook;
    private int _referenceChapter;
    private int _referenceVerse;
    private int _referenceEndVerse;

    public void SetReferenceScripture(string referenceBook, int referenceChapter, int referenceVerse)
    {
        _referenceBook = referenceBook;
        _referenceChapter = referenceChapter;
        _referenceVerse = referenceVerse;
    }
    public void SetReferenceScripture(string referenceBook, int referenceChapter, int referenceVerse, int referenceEndVerse)
    {
        _referenceBook = referenceBook;
        _referenceChapter = referenceChapter;
        _referenceVerse = referenceVerse;
        _referenceEndVerse = referenceEndVerse;
    }

    public bool CheckIfNull()
    {
        if (_referenceEndVerse == 0)
        {
            return true;
        } else
        {
            return false;
        }
    }
    public void DisplayReferenceScripture()
    {
        Console.WriteLine($"{_referenceBook} {_referenceChapter}:{_referenceVerse}");
    }
    public void DisplayReferenceLongScripture()
    {
        Console.WriteLine($"{_referenceBook} {_referenceChapter}:{_referenceVerse}-{_referenceEndVerse}");
    }
}