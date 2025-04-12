using System;
using System.Collections.Generic;
using System.IO;

// Class to manage the list of goals and points
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    // Constructor
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // Display the current score
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    // List all goals
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    // Add a new goal
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    // Record an event
    public void RecordEvent()
    {
        // To be implemented
    }

    // Save goals to file
    public void SaveGoals(string filename)
    {
        // To be implemented
    }

    // Load goals from file
    public void LoadGoals(string filename)
    {
        // To be implemented
    }

    // Create a new goal
    public void CreateGoal()
    {
        // To be implemented
    }
}
