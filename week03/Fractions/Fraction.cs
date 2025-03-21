using System;
using System.Runtime.CompilerServices;

public class Fraction
{

    private int _top;
    private int _bottom;

    public Fraction()
    {
        //Deafult to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        SetTop(wholeNumber);
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        SetTop(top);
        SetBottom(bottom);
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }



}