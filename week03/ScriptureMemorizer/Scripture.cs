
public class Scripture
{

    Reference r = new Reference();

    private string _text;
    private List<Words> _words = new List<Words>();
    public void SetUserScripture(string referenceBook, int referenceChapter, int referenceVerse, string referenceEndVerseString, string text)
    {
        if (referenceEndVerseString != "")
        {
            int referenceEndVerse = int.Parse(referenceEndVerseString);
            r.SetReferenceScripture(referenceBook, referenceChapter, referenceVerse, referenceEndVerse);

        }
        else
        {
            r.SetReferenceScripture(referenceBook, referenceChapter, referenceVerse);
        }

        _text = text;
    }

    public void DisplayScripture()
    {
        bool endVerse = r.CheckIfNull();
        if (endVerse == true)
        {
            r.DisplayReferenceScripture();
        }
        else if (endVerse == false)
        {
            r.DisplayReferenceLongScripture();
        }

        Console.WriteLine(_text);
    }
    public void SeparateVerseIntoWords()
    {
        string[] splittedText = _text.Split(new[] { " ", ",", "." }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in splittedText)
        {
            Words w = new Words();
            w.SetWord(word);
            _words.Add(w);
        }

    }
    public static Random rnd = new Random();
    public void HideRandomWords()
    {
        int wordsToHide = 3;
        int hiddenCount = 0;

        while (hiddenCount < wordsToHide)
        {
            int index = rnd.Next(_words.Count);

            if (!_words[index].GetIfHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    } 
    public bool IsCompletelyHidden()
    {
        int finalCount = 0;
        foreach (Words w in _words)
        {

            if (w.GetIfHidden() == true)
            {
                finalCount += 1;
            }
        }
        if (finalCount == _words.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void GetDisplayText()
    {
        foreach (Words word in _words)
            word.DisplayText();
    }
    
}