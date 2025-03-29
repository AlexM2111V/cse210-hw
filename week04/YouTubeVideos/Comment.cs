using System;

public class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }
    public string DisplayComment()
    {
        string commentDetails = $"Posted by {_name}: \"{_text}\"";
        return commentDetails;
    }
}