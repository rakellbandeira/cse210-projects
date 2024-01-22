using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    //multiple constructors ahead:
    public Fraction() // this is a constructor
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top) // this is a constructor
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) // this is a constructor
    {
        _top = top;
        _bottom = bottom;
    }





    public void DisplayFraction() // method with an action
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }

    //Creating gettings and setters for both numbers

    public int GetNumerator()
    {
        return _top;
    }

    public void SetNumerator(int top)
    {
        _top = top;
    }

    public int GetDenominator()
    {
        return _bottom;
    }

    public void SetDenominator(int bottom)
    {
        _bottom = bottom;
    }




    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        double division = _top/_bottom;
        return division;
    }
}