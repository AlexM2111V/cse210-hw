using System;
using System.Dynamic;

public abstract class Activity
{
    private string _date;
    private int _length;
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public double GetLength()
    {
        return _length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetType();

    public void GetSummary(){
        Console.Write($"\n{_date} {GetType()} ({_length} min): Distance {GetDistance():0.00} km, Speed: {GetSpeed():0.00} kph, Pace: {GetPace():0.00} min per km");
    }
}