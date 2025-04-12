using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool quit = false;

        while (!quit)
        {
            // Display the menu
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Create new goal
                    manager.CreateGoal();
                    break;
                case "2":
                    // List goals
                    manager.ListGoalDetails();
                    break;
                case "3":
                    // Save goals
                    Console.Write("What is the filename for the goal file? ");
                    string saveFilename = Console.ReadLine();
                    manager.SaveGoals(saveFilename);
                    break;
                case "4":
                    // Load goals
                    Console.Write("What is the filename for the goal file? ");
                    string loadFilename = Console.ReadLine();
                    manager.LoadGoals(loadFilename);
                    break;
                case "5":
                    // Record event
                    manager.RecordEvent();
                    break;
                case "6":
                    // Quit
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            // Display current score after each action (except quitting)
            if (!quit)
            {
                manager.DisplayPlayerInfo();
            }
        }

        Console.WriteLine("Thank you for using the Eternal Quest program!");
    }
}
