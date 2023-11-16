public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(bool isComplete, int points, string name, string description)
        : base(points, name, description)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        _isComplete = true;

        return base.GetPoints();
    }

    public override bool CheckOff()
    {
        return _isComplete;
    }

    public override string GetFileLine()
    {
        string fileLine = $"SimpleGoal:{base.GetName()},{base.GetDescription()},{base.GetPoints()},{_isComplete}";

        return fileLine;
    }

    public override string DisplayGoal()
    {
        string goalDetails = $"{base.GetName()} ({base.GetDescription()})";

        return goalDetails;
    }
}