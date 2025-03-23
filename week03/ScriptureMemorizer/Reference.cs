using System;
using System.Runtime.InteropServices;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        SetBook(book);
        SetChapter(chapter);
        SetVerse(verse);
        SetEndVerse(0); //I set this to zero to recognize when the scripture has no end verse
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        SetBook(book);
        SetChapter(chapter);
        SetVerse(startVerse);
        SetEndVerse(endVerse);
    }
    public string GetBook()
    {
        return _book;
    }
    public void SetBook(string book)
    {
        _book = book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
    public int GetVerse()
    {
        return _verse;
    }
    public void SetVerse(int verse)
    {
        _verse = verse;
    }
    public int GetEndVerse()
    {
        return _endVerse;
    }
    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        string text;
        if (_endVerse == 0)
        {
            text = $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            text = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        return text;
    }
}