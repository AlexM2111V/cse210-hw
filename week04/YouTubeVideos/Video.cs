using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void DisplayVideoInfo()
    {
        string videoInfo = $"\n{_title} by {_author} lasts {_length} seconds and has {GetNumberOfComments()} comments.";
        Console.WriteLine(videoInfo);
        DisplayComments();
    }
    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
            Console.WriteLine(comment.DisplayComment());
    }
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}