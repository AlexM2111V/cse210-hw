using System;

public class Cycling : Activity
{
    private double _speed;
    public Cycling (string date, int length, double speed) :base (date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = _speed * (GetLength() / 60);
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetType()
    {
        return "Cycling";
    }
}