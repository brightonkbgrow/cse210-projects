using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;
    
    public Fraction()
    {
        _numerator = 1;
        _denominator = 3;
    }
    public int Numerator
    {
        get {return _numerator;}
        set { _numerator = value;}
    }
    public int GetDenominator
    {
        get {return _denominator;}
        set { _denominator = value;}
    }
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }
    public float GetDecimalValue()
    {
        return (float)_numerator/_denominator;
    }
}
