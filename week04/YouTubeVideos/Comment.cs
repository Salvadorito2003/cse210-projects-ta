public class Comment
{
    private string _author;
    private string _text;

    public void SetComment(string author, string text)
    {
        _author = author;
        _text = text;
    }
    public void DisplayComment()
    {
        Console.WriteLine(_author);
        Console.WriteLine(_text);
        Console.WriteLine();
    }
}