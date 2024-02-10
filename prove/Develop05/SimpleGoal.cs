public class SimpleGoal: Goal
{
    public bool _isComplete;

    public SimpleGoal(string name, string description, int points): base(name, description, points)
    {
        
        _isComplete = false;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal, {_shortName}, {_description}, {_points}, {_isComplete}";
    }

    public override string GetDetailString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_shortName} ({_description})";
    }
}