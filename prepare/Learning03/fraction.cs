using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;
    
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public int GetNumerator()
    {
        return _numerator;
    }
    public int GetDenominator()
    {
        return _denominator; 
    }
    public void SetFraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;

    }
    public int ShowFraction()
    {
        return _numerator/_denominator;
    }
}
