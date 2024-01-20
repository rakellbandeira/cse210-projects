using System;

public class JournalEntry
{

    /*
        variables:
        _data: string
        _prompText: string
        _entryText: string
        
        methods:
        JournalEntry(): void
        ToString() method creates a string representation
        of an object of that class and returns a formatted string 
        of the JournalEntry that is easier and readable to display.
        I found help about this in:
        https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=&cad=rja&uact=8&ved=2ahUKEwj6w-3whu2DAxWeqJUCHdgaCGUQFnoECA4QAw&url=https%3A%2F%2Flearn.microsoft.com%2Fen-us%2Fdotnet%2Fapi%2Fsystem.object.tostring%3Fview%3Dnet-8.0&usg=AOvVaw0HVo-Ygg6nTBn7a7KZ8T3e&opi=89978449

    */

    public string _prompText;
    public string _entryText;
    public string _date;

    public JournalEntry (string prompt, string response, string date)
    {
        _prompText = prompt;
        _entryText = response;
        _date = date;

       
    }

    public override string ToString()
    {
        return $"Date: {_date} Prompt of the Day: {_prompText} Your Response:{_entryText}";
    }
}