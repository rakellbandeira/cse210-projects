using System;

class Program
{
    static void Main(string[] args)
    {
        Address eventAddress = new Address("123 Main St", "Cityville", "State", "12345");
        Lecture lectureEvent = new Lecture("Interesting Lecture", "A fascinating talk on various subjects.", DateTime.Now, "2:00 PM", eventAddress, "John Doe", 50);
        Reception receptionEvent = new Reception("Networking Mixer", "Join us for a night of connections and fun.", DateTime.Now.AddDays(7), "6:30 PM", eventAddress, "rsvp@example.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Summer Picnic", "Enjoy outdoor activities and great food.", DateTime.Now.AddDays(14), "12:00 PM", eventAddress, "Sunny with a high of 75°F");

        // Displaying marketing messages for each event
        Console.WriteLine("Standard Details:\n------------------");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n--------------");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:\n-------------------");
        Console.WriteLine(lectureEvent.GetShortDescription());

        Console.WriteLine("\n\nStandard Details:\n------------------");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n--------------");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:\n-------------------");
        Console.WriteLine(receptionEvent.GetShortDescription());

        Console.WriteLine("\n\nStandard Details:\n------------------");
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n--------------");
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:\n-------------------");
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
} 
    
