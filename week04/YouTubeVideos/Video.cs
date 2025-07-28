public class Video
{
    private string _title;
    private string _author;
    private float _lenght;
    private List<Comment> _commentsList = new List<Comment>();

    public void SetVideoInformation(string title, string author, string lenght)
    {
        _title = title;
        _author = author;
        _lenght = float.Parse(lenght);
    }

    public void SetVideoComment(string commentAuthor, string commentText)
    {
        Comment c = new Comment();
        c.SetComment(commentAuthor, commentText);
        _commentsList.Add(c);
    }
    public void CountNumberOfComments()
    {
        int commentNumber = _commentsList.Count();
        Console.WriteLine($"Comments: {commentNumber}");
    }
    public void DisplayVideoInformation()
    {
        Console.WriteLine($"{_title}, {_author} - {_lenght} Seconds");
    }
    public void DisplayComments()
    {
        foreach (Comment comment in _commentsList)
        {
            comment.DisplayComment();
        }
    }
}