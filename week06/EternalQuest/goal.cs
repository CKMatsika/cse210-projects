using System;

// Abstract base class for all goal types
public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    // Abstract method that must be implemented by derived classes
    public abstract int RecordEvent();

    // Virtual method that can be overridden by derived classes if needed
    public virtual string GetDetailsString()
    {
        string completionStatus = _isComplete ? "[X]" : "[ ]";
        return $"{completionStatus} {_name} ({_description})";
    }

    // Method to check if goal is complete
    public bool IsComplete()
    {
        return _isComplete;
    }

    // Method to get string representation for saving to file
    public virtual string GetStringRepresentation()
    {
        return "";
    }
}
