using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //setting constructors

    public Reference (string randomReference)
    {
        _book = randomReference;
    }
    public Reference( string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }

    public Reference( string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayTextRef()
    {
        /* if (_endVerse != 0)
        {
            return $"{_book} {_chapter}: {_verse}-{_endVerse}";
        }
        
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        } */

        return _book;
        
    }

}