using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;


    public Scripture(Reference reference, string text)
    {
        // this constructor has the responsability of creating the list,
        //splitting up the words in the string to create Word objects
        //for each one and put them in the list.
        _reference = reference;

        List<Word> _wordList = new List<Word>(); 

        //apparently, split methods can be used only in arrays, so
        //I am creating an array and passing it down to the list.

        string[] wordArray = text.Split(" ");

        foreach (string word in wordArray)
        {
            Word eachWord = new Word(word); // each element MUST be molded by Word class
            _wordList.Add(eachWord);
        }

        _words = _wordList;        
    }

    public void HideRandomWords (int numberToHide)
    {
        //This class is responsible for generating random numbers
        //that will be indexes used to update the 'isHidden' state
        ///of each word in the list. This will invoked by Program 
        //class.

        Random randomObject = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = randomObject.Next(_words.Count);
            _words[randomIndex].Hide(); // invoking the setter to change the variable 'isHidden'
        }

    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

    public string GetDisplayScrip() // putting it together in a string
    {
        string allStringsTogether = ""; // had to intialize it empty to be assigned more added values later

        foreach (Word word in _words)
        {
            allStringsTogether += word.GetDisplayTextWord() + " ";

        }

        return $"Scripture: {allStringsTogether} {_reference.GetDisplayTextRef()}";
    }


}