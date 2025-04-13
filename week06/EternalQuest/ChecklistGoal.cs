using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal (string name, string description, int points, int target, int bonus) :base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
    }
    public override bool IsComplete()
    {
        if ( _amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        if (IsComplete()){
            return $"[X] {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else{
            return $"[ ] {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }        
    }
    public override string GetStringRepresentation()
    {
        return ($"ChecklistGoal~{GetName()}~{GetDescription()}~{GetPoints()}~{IsComplete()}~{_target}~{_bonus}~{_amountCompleted}");
    }
}