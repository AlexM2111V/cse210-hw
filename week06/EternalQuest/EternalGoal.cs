using System;
using System.ComponentModel;

public class EternalGoal : Goal
{    
    public EternalGoal(string name, string description, int points) :base (name, description, points)
    {
        SetPoints(points);
    }

    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return ($"EternalGoal~{GetName()}~{GetDescription()}~{GetPoints()}");
    }
}