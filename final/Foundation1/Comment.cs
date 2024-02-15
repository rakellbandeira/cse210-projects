class Comment
{
    private string _namePerson;
    private string _textComment;


    public Comment(string name, string text)
    {
        _namePerson = name;
        _textComment = text;
    }

    public void DisplayComments()
    {
        Console.WriteLine($"\n- @{this._namePerson}: \n'{this._textComment}'\n");
    }

}


