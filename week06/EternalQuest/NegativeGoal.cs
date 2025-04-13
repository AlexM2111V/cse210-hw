using System;
using System.ComponentModel;

public class NegativeGoal : Goal
{    
    public NegativeGoal(string name, string description, int points) :base (name, description, points)
    {
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
        return ($"NegativeGoal~{GetName()}~{GetDescription()}~{GetPoints()}");
    }
}