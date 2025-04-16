using System;
using System.Globalization;

public class Running : Activity
{
    private double _distance;
    public Running(string date, int length, double distance) :base (date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = (_distance / GetLength()) * 60;
        return speed;
    }
    public override double GetPace()
    {
        double pace =  GetLength() / _distance;
        return pace;
    }

    public override string GetType()
    {
        return "Running";
    }
}