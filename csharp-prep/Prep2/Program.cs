using System;

class Program
{
    static void Main(string[] args)
    {
        

        Console.Write("Hello, what is your grade percentage?");
        int gradePercent = int.Parse(Console.ReadLine());
        char letter;
        

        if (gradePercent < 60)
        {
            
            letter = 'F';
        }

        else if (gradePercent >= 60)
        {
            
            letter = 'D';
        }

        else if (gradePercent >=70)
        {
            
            letter = 'C';
        }

        else if (gradePercent >=80)
        {
            
            letter = 'B';
        }

        else
        {
            
            letter = 'A';
        }

        Console.WriteLine($"Your grade is: {letter}.");

        if (gradePercent >=70)
        {
            Console.WriteLine("Congratulations! You passed this class.");
        }
        else
        {
            Console.WriteLine("Sorry. Your grades are too low to pass, but you can try again next time!");
        }


    }
}