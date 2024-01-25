using System;

class Word
{
    private string _text;
    private bool _isHidden;


    // setting the constructor

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // setting the methods

    public bool IsHidden() // This is a getter
    {
        return _isHidden;
    }

    public void Hide() // this is a setter
    {
        _isHidden = true;
    }

    public void Show() // this is a setter
    {
        _isHidden = false;
    }


    public string GetDisplayTextWord()
    {
        
        if (_isHidden == false)
        {
            return _text;
        }
        else
        {
            //get the text string and its length.
            // create a new string that will represent the word w/ "_".
            //put one underscore per word's length using a loop
            int numbChar = _text.Length;
            string wordUnderScored = "";

            for (int i = 0; i < numbChar + 1; i++)
            {
                wordUnderScored += "_";
            }

            // returns a string representing each word
            return wordUnderScored;
        }

        


    }

}