using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        
        // Testing the first constructor (no parameters) - should create 1/1
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        
        // Testing the second constructor (one parameter) - should create 5/1
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
        
        // Testing the third constructor (two parameters) - should create 3/4
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
        
        // Testing the third constructor again with different values - should create 1/3
        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
        
        // Testing getters and setters
        Console.WriteLine("\nTesting getters and setters:");
        Fraction fraction5 = new Fraction(1, 2);
        Console.WriteLine($"Original: {fraction5.GetFractionString()}");
        
        // Using setters to change values
        fraction5.Numerator = 3;
        fraction5.Denominator = 5;
        
        // Using getters to retrieve and display new values
        Console.WriteLine($"New numerator: {fraction5.Numerator}");
        Console.WriteLine($"New denominator: {fraction5.Denominator}");
        Console.WriteLine($"New fraction: {fraction5.GetFractionString()}");
        Console.WriteLine($"Decimal value: {fraction5.GetDecimalValue()}");
    }
}