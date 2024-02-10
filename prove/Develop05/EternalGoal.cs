public class EternalGoal: Goal
{

    public EternalGoal(string name, string description, int points): base (name, description, points)
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {
      
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal: {_shortName}, {_description}, {_points}";
    }

    public override string GetDetailString()
    {
        return $"[ ] {_shortName} ({_description})";
    }
}