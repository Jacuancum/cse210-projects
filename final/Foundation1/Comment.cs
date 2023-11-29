class Comment
{
    public string _commenterName;
    public string _text;
    public string CommenterName()
    {
        return _commenterName;
    }
    public string Text()
    {
        return _text;
    }
    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }
}