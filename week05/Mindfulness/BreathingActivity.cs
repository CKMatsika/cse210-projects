using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            
            Console.Write("\nNow breathe out...");
            ShowCountDown(6);
            
            Console.WriteLine();
        }
        
        DisplayEndingMessage();
    }
}