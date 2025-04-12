using System;

// Simple goal that can be completed once
public class SimpleGoal : Goal
{
    // Constructor
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        // No need for a parameter for _isComplete as it defaults to false
    }

    // Constructor that includes completion status (for loading from file)
    public SimpleGoal(string name, string description, int points, bool isComplete) 
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    // Implementation of the abstract method from base class
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    // Implementation of string representation for saving
    public override string GetStringRepresentation()
    {
        return "";
    }
}
