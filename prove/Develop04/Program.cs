using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput;

        
        BreathingActivity breathingActivity;
        ReflectingActivity reflectActivity;
        ListingActivity listingActivity;

        do
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu:");
            userInput = int.Parse(Console.ReadLine());


            switch (userInput)
            {
                case 1:
                    Console.Clear();
                    breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathingActivity.Run();
                    break;

                case 2:
                    Console.Clear();
                    reflectActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflectActivity.Run();
                    break;

                case 3:
                    Console.Clear();
                    listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listingActivity.Run();
                    break;

            }


        } while (userInput != 4);

        Console.WriteLine("");
        Console.WriteLine("You quit.");
        Environment.Exit(0);

    }
}