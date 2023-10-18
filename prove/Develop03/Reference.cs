using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public void DisplayReference()
    {
        string reference = ($"{_book} {_chapter}:{_verse}-{_endVerse} ");
        Console.Write(reference);
    }

    public void DisplayShortReference()
    {
        string reference = ($"{_book}{_chapter}:{_verse} ");
        Console.Write(reference);
    }
}
