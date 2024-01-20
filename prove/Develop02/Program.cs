using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();

        while(true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.WriteLine("Choose an option (1-5): ");
            string userChoice = Console.ReadLine();
            int choice = int.Parse(userChoice);
            

            if (choice == 1)
            {
/*                 Console.WriteLine("Ok, let's write a new page of your journal: ");
 */                /* PromptGenerator promptOfDay = new PromptGenerator(); */
                

                /* Console.WriteLine($"Here's a prompt for you: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine(); */

                journal.AddEntry(prompt.GetRandomPrompt());

                break;

            }


            else if (choice == 2)
            {
                journal.DisplayEntries();

                break;
            }


            else if (choice == 3)
            {
                Console.Write($"Enter a name for the file (ex: file.txt:) ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);

                /* Console.Write($"New file {filename} added successfully."); */

                break;
            }


            else if (choice == 4)
            {
                Console.WriteLine($"Which file do you want to load? ");
                string fileToOpen = Console.ReadLine();

                journal.LoadFromFile(fileToOpen);

                break;
            }

            else if (choice == 5)
            {
                Console.WriteLine("Leaving the Journal Program...");
                Console.WriteLine("XOXO, Dear Human.");

                break;
            } 

            else
            {
                Console.WriteLine("Invalid choice. Please enter a valid option.");
                break;
            }    

        }
    }
}