using System;

class Program
{
    static void Main(string[] args)
    {
         List<Activity> activities = new List<Activity>();

        // Creating instances of each activity type
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
        activities.Add(new StationaryBicycles(new DateTime(2022, 11, 3), 30, 20.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 10));

        // Displaying summaries for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}