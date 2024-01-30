using System;

public class BreathingActivity: Activity
{
    
    public BreathingActivity(string name, string description) : base (name, description)
    {
        _name = name;
        _description = description;

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        

        Console.Clear();
        Console.Write("Get ready...");
        ShowSpinner(4);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        string startTimeTime = startTime.ToString("HH:mm:ss");
        DateTime endTime = startTime.AddSeconds(_duration);
        string endTimeTime = endTime.ToString("HH:mm:ss");
        DateTime currentTime = DateTime.Now;
        string currentTimeTime = currentTime.ToString("HH:mm:ss");
        

        /* Console.WriteLine($"This is the duratino the activity will last: {_duration}.");
        Console.WriteLine($"This is the start time: {startTimeTime} and this is the end time: {endTimeTime}.");
        Console.WriteLine($"This is the current time: {currentTimeTime}."); */
        Console.WriteLine("");

        while (currentTime < endTime)
        {   
            currentTime = DateTime.Now;
            /* Console.WriteLine($"Current time now: {currentTime}."); */
            Console.Write("Breath in...");
            ShowCountDown(3);
            Console.WriteLine("\b.");
            Console.Write("Now breath out...");
            ShowCountDown(6);
            Console.WriteLine("\b.");
            
            /* Console.WriteLine($"Current time now: {currentTime}."); */
            Console.WriteLine("");

        }

        DisplayEndingMessage();
    }
}