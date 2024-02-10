public class ChecklistGoal: Goal
{
    public int _amountCompleted;
    public int _target;
    public int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted == _target)
        {
            _points += +_bonus;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target ? true : false;

    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal, {_shortName}, {_description}, {_points}, {_amountCompleted}, {_target}, {_bonus}";
    }

    public override string GetDetailString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description}) --- Currently completed:{_amountCompleted}/{_target} ";
    }


}