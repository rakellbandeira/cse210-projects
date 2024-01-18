using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while(true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option (1-5): ");
            string userChoice = Console.ReadLine();
            int choice = int.Parse(userChoice);
            

            if (choice == 1)
            {
                Console.WriteLine("Ok, let's write a new page of your journal: ");
                PromptGenerator prompt = new PromptGenerator();
                /* string promptOfDay = prompt.ToString(); */

                Console.WriteLine($"Here's a prompt for you: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                journal.AddEntry(prompt, response)

            }

        }
    }
}