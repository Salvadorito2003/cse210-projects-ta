public class Words
{
    private string _word;
    private bool _isHidden = false;

    public void SetWord(string word)
    {
        _word = word;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public bool GetIfHidden()
    {
        if (_isHidden == false)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void DisplayText()
    {
        if (_isHidden)
        {
            Console.Write(new string('_', _word.Length) + " ");
        }
        else
        {
            Console.Write(_word + " ");
        }
    }
}