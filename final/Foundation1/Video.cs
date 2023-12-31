using System.Diagnostics.Contracts;

class Video
{
    public string _title;
    public string _author;
    public int _length;
    private List<Comment> comments;
    public string Title()
    {
        return _title;
    }
    public string Author()
    {
        return _author;
    }
    public int Length()
    {
        return _length;
    }
    public List<Comment> Comments()
    {
        return comments;
    }
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string text)
    {
        Comment comment = new Comment(commenterName, text);
        comments.Add(comment);
    }

    public int GetNumComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}