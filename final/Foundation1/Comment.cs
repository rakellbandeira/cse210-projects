class Comment{
    private string _namePerson;
    private string _textComment;


public Comment(string name, string text)
{
    _namePerson = name;
    _textComment = text;
}

public void DisplayComments()
{
    Console.WriteLine($"- @{this._namePerson}: \n{this._textComment}");
}


//Are they necessary?
    public void SetNamePerson(string name)
    {
        _namePerson = name;
    }

    public string GetTextComment()
    {
        return _textComment;
    }
}