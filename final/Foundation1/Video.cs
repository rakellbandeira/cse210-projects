class Video
{
    private string _title;
    private string _author;
    private int _length;
    List<Comment> _commentsList;

    public Video (string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _commentsList = new List<Comment>();
    }

    public int GetNumberComments()
    {
        int numberComments = _commentsList.Count();
        return numberComments;
    }

    public void SetNewComment(string name, string text)
    {
        Comment newComment = new Comment(name, text);
        _commentsList.Add(newComment);
    }


    public void DisplayVideo()
    {
        Console.WriteLine($"\nTitle: {this._title}");
        Console.WriteLine($"Author: {this._author}");
        Console.WriteLine($"Length: {this._length} seconds");
        Console.WriteLine($"Number of comments: {this.GetNumberComments()}");

    }

    public void DisplayAllComments()
    {
        Console.WriteLine($"First 3 Comments:");
        foreach (Comment comment in _commentsList)
        {
            comment.DisplayComments();
        }
    }

}