using System;
using System.IO;
using System.Linq.Expressions;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            DisplayPlayerInfo();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("\t1. Create a New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.Write("\nSelect a choice from the menu: ");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    CreateGoal();
                    break;

                case "2":
                    ListGoalDetails();
                    break;

                case "3":
                    SaveGoals();
                    break;

                case "4":
                    LoadGoals();
                    break;

                case "5":
                    RecordEvent();
                    break;

                case "6":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;

            }

        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nCurrent Score: {_score}\n");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("\n--The goals are: --");
        
        for (int i = 1; i <= _goals.Count; i++)
        {
            
            Console.WriteLine($"\t{i}. {_goals[i - 1]._shortName}");
        }
        Console.WriteLine();
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\n-- Goal Details --");
        for (int i = 1; i <= _goals.Count; i++)
        {
            Console.WriteLine($"\t{i}. {_goals[i - 1].GetDetailString()}");
        }
        Console.WriteLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nChoose Goal Type:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");

        Console.Write("\nEnter your choice: ");
        string goalTypeChoice = Console.ReadLine();

        Console.Write("Enter Goal Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Goal Description: ");
        string description = Console.ReadLine();

        Console.Write("Enter Points for Completing the Goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (goalTypeChoice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                Console.WriteLine("\nNew Simple Goal added!");
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                Console.WriteLine("\nNew Eternal Goal added!");
                break;
            case "3":
                Console.Write("Enter Target for Checklist Goal: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter Bonus for Completing Checklist Goal: ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                Console.WriteLine("\nNew Checklist Goal added!");
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter a valid option.");
                break;
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("\nEnter the number of the goal you've accomplished: ");
        int goalNumber = int.Parse(Console.ReadLine());

        if (goalNumber >= 1 && goalNumber <= _goals.Count)
        {
            Goal goal = _goals[goalNumber - 1];
            goal.RecordEvent();
            _score += goal._points;
            Console.WriteLine($"\nEvent recorded for {goal._shortName}. You earned {goal._points} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal number. Please enter a valid number.");
        }
    }

    public void SaveGoals()
    {

        Console.Write("\nEnter the file to be saved: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            
            foreach (var goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
                
            }
        }

        Console.WriteLine($"Goals saved to {fileName}.");
    }

    public void LoadGoals()
    {
        _goals.Clear();

        Console.Write("\nEnter the file to be loaded: ");
        string filetoBeLoaded = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filetoBeLoaded);
        /* string[] lines = File.ReadAllLines(filetoBeLoaded); */

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {   string[] goalInfo = lines[i].Split(',');
            
            string goalType = goalInfo[0];
            string name = goalInfo[1];
            string description = goalInfo[2];
            int points = int.Parse(goalInfo[3]);

            if (goalType == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            }

            else if (goalType == "EternalGoal")
            {
                _goals.Add(new EternalGoal(name, description,points));
                break;
            }

            else if (goalType == "ChecklistGoal")
            {
                int amountCompleted = int.Parse(goalInfo[4]);
                int target = int.Parse(goalInfo[5]);
                int bonus = int.Parse(goalInfo[6]);
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus){_amountCompleted = amountCompleted});
                break;
            }

            /* switch(goalType)
            {
                case "SimpleGoal":
                        _goals.Add(new SimpleGoal(name, description, points));
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(name, description, points));
                        break;
                    case "ChecklistGoal":
                        int amountCompleted = int.Parse(goalInfo[4]);
                        int target = int.Parse(goalInfo[5]);
                        int bonus = int.Parse(goalInfo[6]);
                        _goals.Add(new ChecklistGoal(name, description, points, target, bonus) { _amountCompleted = amountCompleted });
                        break;
            } */

            Console.WriteLine("");

        }

        Console.WriteLine($"\nGoals loaded from {filetoBeLoaded}.");

    }   
            

    }
