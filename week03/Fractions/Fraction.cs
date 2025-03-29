using System;

/// <summary>
/// Represents a fraction with a numerator and denominator.
/// </summary>
public class Fraction
{
    // Private attributes
    private int _numerator;
    private int _denominator;

    /// <summary>
    /// Default constructor that initializes the fraction to 1/1.
    /// </summary>
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    /// <summary>
    /// Constructor that initializes the fraction with a specified numerator and denominator of 1.
    /// </summary>
    /// <param name="numerator">The numerator of the fraction.</param>
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    /// <summary>
    /// Constructor that initializes the fraction with specified numerator and denominator.
    /// </summary>
    /// <param name="numerator">The numerator of the fraction.</param>
    /// <param name="denominator">The denominator of the fraction.</param>
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        
        // Prevent division by zero
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
        }
        
        _denominator = denominator;
    }

    /// <summary>
    /// Gets or sets the numerator of the fraction.
    /// </summary>
    public int Numerator
    {
        get { return _numerator; }
        set { _numerator = value; }
    }

    /// <summary>
    /// Gets or sets the denominator of the fraction.
    /// </summary>
    public int Denominator
    {
        get { return _denominator; }
        set
        {
            if (value == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            _denominator = value;
        }
    }

    /// <summary>
    /// Returns a string representation of the fraction in the form "numerator/denominator".
    /// </summary>
    /// <returns>A string representation of the fraction.</returns>
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    /// <summary>
    /// Returns the decimal value of the fraction.
    /// </summary>
    /// <returns>The decimal value of the fraction as a double.</returns>
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}