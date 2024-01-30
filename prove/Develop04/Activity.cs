using System;

public class Activity
{
    protected string _name = "";
    protected string _description;
    protected int _duration = 0;

    //constructor
    public Activity (string name, string description)
    {
        _name = name;
        _description = description;
        
    }

    public void DisplayStartingMessage()
    {
        // All of them have this class, but the text is different for each,
        // so it will probably receive a string argument each time it is called.
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("");
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!");
        Thread.Sleep(3000);
        Console.WriteLine("");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        Console.WriteLine("");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>
        {
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\"
        };

        DateTime startTime =  DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;
        }

                
        
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
}