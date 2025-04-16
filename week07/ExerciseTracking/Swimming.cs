using System;

public class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, int length, int laps) :base (date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (double)_laps * 50 / 100;
    }

    public override double GetSpeed()
    {
        double speed = (GetDistance() / GetLength()) * 60;
        return speed;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetType()
    {
        return "Swimming";
    }
}