using System;
using System.Collections.Generic;

// Base class for all activities
public abstract class Activity
{
    // Shared attributes for all activities
    private DateTime _date;
    private int _minutes;

    // Constructor
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Properties
    public DateTime Date { get { return _date; } }
    public int Minutes { get { return _minutes; } }

    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // GetSummary method available for all activities
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_minutes} min)- " +
               $"Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, " +
               $"Pace: {GetPace():F1} min per mile";
    }
}

// Derived class for Running activity
public class Running : Activity
{
    private double _distance; // in miles

    // Constructor
    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    // Implementation of abstract methods
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / Minutes) * 60;
    }

    public override double GetPace()
    {
        return Minutes / _distance;
    }
}

// Derived class for Cycling activity
public class Cycling : Activity
{
    private double _speed; // in mph

    // Constructor
    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    // Implementation of abstract methods
    public override double GetDistance()
    {
        return (_speed * Minutes) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}

// Derived class for Swimming activity
public class Swimming : Activity
{
    private int _laps;

    // Constructor
    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    // Implementation of abstract methods
    public override double GetDistance()
    {
        // Convert laps to miles: laps * 50 meters per lap / 1000 to km * 0.62 to miles
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Create at least one activity of each type
        List<Activity> activities = new List<Activity>();
        
        // Running activity - date, minutes, distance in miles
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
        
        // Cycling activity - date, minutes, speed in mph
        activities.Add(new Cycling(new DateTime(2022, 11, 4), 45, 15.0));
        
        // Swimming activity - date, minutes, laps
        activities.Add(new Swimming(new DateTime(2022, 11, 5), 60, 20));

        // Display summary for each activity
        Console.WriteLine("Fitness Activity Tracking:");
        Console.WriteLine("=========================");
        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
