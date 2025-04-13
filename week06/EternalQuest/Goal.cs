using System;

public abstract class Goal
{
    private string _shortname;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortname = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortname;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        if (IsComplete()){
            return $"[X] {_shortname} ({_description})";    
        }
        else{
            return $"[ ] {_shortname} ({_description})";
        }        
    }
    public abstract string GetStringRepresentation();
}