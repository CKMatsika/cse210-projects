using System;

// Eternal goal that can never be completed but gives points each time
public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        // No additional member variables needed
    }

    // Implementation of the abstract method from base class
    public override int RecordEvent()
    {
        // Eternal goals are never complete, just return points
        return _points;
    }

    // Implementation of string representation for saving
    public override string GetStringRepresentation()
    {
        return "";
    }
}
